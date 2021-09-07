using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using DigiLinXLibrary.Network.Packets;
using Timer=System.Timers.Timer;

namespace DigiLinXLibrary.Network {
    /// <summary>
    /// This class handles the trafficing of NetStreams packets from the multicast location. 
    /// It only handles the arrival of packets, and not logging or anything else
    /// When a packet arrives, the event <seealso cref="OnPacketArrival"/> is called
    /// The client can be told to only listen for messages from a specific device by using the <seealso cref="DeviceBeingWatched"/> property.
    /// </summary>
    public class DigiLinXMulticastClient {
        #region Delegates

        public delegate void PacketArrived(NetStreamsPacket aPacket);

        #endregion

        private readonly Queue<NetStreamsPacket> packetQueue = new Queue<NetStreamsPacket>();
        private readonly IPAddress theMulticastAddress;
        private readonly int theMulticastPort;
        private int ActiveSocketIdentifier;
        private IPAddress boundInterfaceIPAddress = IPAddress.Any;
        private SocketState CurrentSocketState;
        private bool isEnabled = false;
        private bool theHttpLoadDeviceInformation = false;
        private int theQueueRefreshTimer = 100;
        private Timer theQueueTimer;

        /// <summary>
        /// Creates a new multicast client that can listen in on DigiLinX traffic
        /// </summary>
        /// <param name="aMulticastPort">Port where the action is</param>
        /// <param name="aMulticastAddress">Multicast address to the party</param>
        public DigiLinXMulticastClient(int aMulticastPort, IPAddress aMulticastAddress) {
            SetupListeningWorker();
            theMulticastPort = aMulticastPort;
            theMulticastAddress = aMulticastAddress;
        }

        /// <summary>
        /// Turns the client on or off. This is the master switch for the multicast client
        /// </summary>
        public bool Enabled {
            get { return isEnabled; }
            set {
                isEnabled = value;
                if(isEnabled) {
                    BeginListeningForPackets();
                    theQueueTimer.Start();
                } else {
                    theQueueTimer.Stop();
                    DequeueAndProcessPackets(null, null);
                    CurrentSocketState.Destroy();
                    ActiveSocketIdentifier = 0;
                }
            }
        }

        public IPAddress BoundInterfaceIPAddress {
            get { return boundInterfaceIPAddress; }
            set { boundInterfaceIPAddress = value; }
        }

        /// <summary>
        /// Numer of milliseconds to wait between queue dumps. 
        /// Setting this to 0 bypasses the queue and dumps the messages to the client immediately
        /// Defult is 100 milliseconds
        /// </summary>
        public int QueueRefreshTimer {
            get { return theQueueRefreshTimer; }
            set { theQueueRefreshTimer = value; }
        }

        /// <summary>
        /// Tells the DigiLinXMulticastClient whether or not to load the configuration 
        /// information from the DigiLinX devices that being traced.
        /// Default is false
        /// </summary>
        public bool LoadDeviceInformation {
            get { return theHttpLoadDeviceInformation; }
            set { theHttpLoadDeviceInformation = value; }
        }

        /// <summary>
        /// Called when a new DigiLinX packet is available
        /// </summary>
        public event PacketArrived OnPacketArrival;

        /// <summary>
        /// Init the background worker thread that listens for multicast messages, and start the queue timer
        /// </summary>
        private void SetupListeningWorker() {
            theQueueTimer = new Timer();
            theQueueTimer.Interval = QueueRefreshTimer;
            theQueueTimer.Elapsed += DequeueAndProcessPackets;
        }

        private void DequeueAndProcessPackets(object sender, EventArgs e) {
            if(packetQueue.Count == 0) return;
            Debug.WriteLine("Queue Length Before: " + packetQueue.Count);

            for(int aCounter = 0; aCounter < packetQueue.Count; aCounter++) {
                NetStreamsPacket thePacket = packetQueue.Dequeue();
                OnPacketArrival(thePacket);
            }
            Debug.WriteLine("Queue Length After: " + packetQueue.Count);
        }

        /// <summary>
        /// Opens and binds the socket, and subscribes to the Multicast group.
        /// </summary>
        private void BeginListeningForPackets() {
            //Use a specific interface, if selected. Otherwise use Any
            IPAddress ipAddressToJoinWith = BoundInterfaceIPAddress.ToString() == "0.0.0.0" ? IPAddress.Any : BoundInterfaceIPAddress;

            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ActiveSocketIdentifier = serverSocket.Handle.ToInt32();

            IPEndPoint ipEndPoint = new IPEndPoint(ipAddressToJoinWith, theMulticastPort);
            serverSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 500);
            serverSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1); //non-exclusive
            serverSocket.Bind(ipEndPoint);

            MulticastOption multicastOption = new MulticastOption(theMulticastAddress);
            serverSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, multicastOption);
            serverSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 10);

            Debug.WriteLine(string.Format("Active Socket Identifier is now {0}", ActiveSocketIdentifier));
            CurrentSocketState = new SocketState(serverSocket);
            StartReceive(CurrentSocketState);
        }

        /// <summary>
        /// Kicks off the asynchronous process that waits for the next UDP packet
        /// </summary>
        private void StartReceive(SocketState socketState) {
            EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);
            Debug.WriteLine(string.Format("BeginReceive Thread {0}", Thread.CurrentThread.GetHashCode()));
            try {
                if(socketState.Identifier == ActiveSocketIdentifier)
                    socketState.RawSocket.BeginReceiveFrom(socketState.MessageBuffer, 0, socketState.MessageBuffer.Length, SocketFlags.None, ref epSender, OnSocketReceive, socketState);
            } catch(ObjectDisposedException) {
                Debug.WriteLine(string.Format("StartReceive called when socket was not valid! {0} {1}", socketState.Identifier, ActiveSocketIdentifier));
            }
        }

        /// <summary>
        /// A packet has arrived on the wire and needs to be queued up for future processing
        /// </summary>
        private void OnSocketReceive(IAsyncResult asyncResult) {
            //The socket state that arrives may no longer hold a valid socket, but it contains a valid message in the bufffer
            SocketState aState = (SocketState) asyncResult.AsyncState;
            try {
                if(!isEnabled) return; //Ignore messages that arrive after Enabled is set false
                EndPoint sendersEndpoint = new IPEndPoint(IPAddress.Any, 0);

                int bytesReceived = aState.RawSocket.EndReceiveFrom(asyncResult, ref sendersEndpoint);
                Debug.WriteLine(string.Format("OnSocketReceive Thread {0} got {1} bytes", Thread.CurrentThread.GetHashCode(), bytesReceived));

                NetStreamsPacket packet = PacketFactory.Fetch(aState.MessageBuffer, (IPEndPoint) sendersEndpoint, theHttpLoadDeviceInformation);
                if(theQueueRefreshTimer > 0) packetQueue.Enqueue(packet);
                else OnPacketArrival(packet);
            } catch {
                /* stopping the listening process leaves some dangling asynchronous listeners 
                 * who will blow up when they return and there is no valid endpoint. Ignore these. */
            } finally {
                if(!aState.IsDisposed)
                    StartReceive(aState.Clear());
                else Debug.WriteLine("Data arrived from an expired socket.");
            }
        }
    }

    public class SocketState {
        public int Identifier;
        public bool IsDisposed;
        public byte[] MessageBuffer;
        public Socket RawSocket;

        public SocketState(Socket aSocket) {
            RawSocket = aSocket;
            Identifier = aSocket.Handle.ToInt32();
            MessageBuffer = new byte[8192];
            IsDisposed = false;
            Console.WriteLine("Socket {0} was created", Identifier);
        }

        public SocketState Clear() {
            MessageBuffer = new byte[8192];
            return this;
        }

        public void Destroy() {
            Console.WriteLine("Socket {0} is being destroyed", Identifier);
            RawSocket.Close();
            //RawSocket.Shutdown(SocketShutdown.Both);
            RawSocket = null;
            Identifier = -1;
            MessageBuffer = new byte[8192];
            IsDisposed = true;
        }
    }
}