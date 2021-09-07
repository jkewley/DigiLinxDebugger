using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

using DigiLinXLibrary.Network;
using DigiLinXLibrary.Network.Packets;

using NetStreamsDebugger.Properties;
using NetStreamsDebugger.Support;

namespace NetStreamsDebugger {
    public partial class DebuggerForm {
        /// <summary>
        /// Once a message is handed off by theDigiLinXClient, we queue it up and extract it later using a thread that's allowed to update the UI.
        /// This also allows us to buffer the incoming messages in a large system so that the UI isn't overrun with updates
        /// </summary>
        private readonly Queue<NetStreamsPacket> packetQueue = new Queue<NetStreamsPacket>();

        private readonly int theQueueRefreshTimer = 100;
        private readonly int theQueueRefreshTimerLarge = 3000;
        private bool isRunning = false;

        /// <summary>
        /// theDigiClient is responsible for capturing and supplying the trace messages from the DigiLinX system
        /// </summary>
        private DigiLinXMulticastClient theDigiClient;

        private Timer theQueueTimer;

        private void chkLargeSystem_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.LargeSystemBehavior = chkLargeSystem.Checked;
            theQueueTimer.Interval = Settings.Default.LargeSystemBehavior ? theQueueRefreshTimerLarge : theQueueRefreshTimer;
        }

        /// <summary>
        /// Init the DigiLinXMulticastClient that listens for multicast messages, and start the queue timer
        /// </summary>
        private void SetupListeningWorker() {
            theDigiClient = new DigiLinXMulticastClient(Settings.Default.MulticastPort, IPAddress.Parse(Settings.Default.MulticastAddress));
            theDigiClient.OnPacketArrival += OnDigiPacketArrival;
            theDigiClient.LoadDeviceInformation = true;
            theDigiClient.QueueRefreshTimer = 0;

            theQueueTimer = new Timer();
            theQueueTimer.Interval = Settings.Default.LargeSystemBehavior ? theQueueRefreshTimerLarge : theQueueRefreshTimer;
            theQueueTimer.Tick += Dequeue;
        }

        /// <summary>
        /// Fires when the DigiLinXMulticastClient hands us a new packet. 
        /// We simply stuff the packet in a queue for future processing
        /// </summary>
        /// <param name="aPacket"></param>
        private void OnDigiPacketArrival(NetStreamsPacket aPacket) {
            packetQueue.Enqueue(aPacket);
        }

        /// <summary>
        /// At regular intervals, pull thepackets out of the queue and add them to the grids
        /// </summary>
        private void Dequeue(object sender, EventArgs e) {
            if(packetQueue.Count < 1) return;
            int queueLength = packetQueue.Count;

            for(int aCounter = 0; aCounter < queueLength; aCounter++) {
                NetStreamsPacket aPacket = packetQueue.Dequeue();

                //can't explain why, but for some reason DeQueue sometimes returns a null NetStreamsPacket. Must be a threading issue
                if(aPacket == null) {
                    new Logger().Fatal(string.Format("NULL PACKET: Queue Length: {0}, Started Out With: {1}, Current Counter: {2}", packetQueue.Count, queueLength, aCounter));
                    continue;
                }

                //Add to client drop down list
                if(!clientsBindingSource.Contains(aPacket.Device)) clientsBindingSource.Add(aPacket.Device);

                allPacketView.Add(aPacket);

                switch(aPacket.MessageType) {
                    case NetStreamsMessageType.Error:
                        errorView.Add(aPacket as ErrorPacket);
                        break;
                    case NetStreamsMessageType.Warning:
                        warningView.Add(aPacket as WarningPacket);
                        break;
                    case NetStreamsMessageType.Info:
                        infoView.Add(aPacket as InfoPacket);
                        break;
                    case NetStreamsMessageType.Driver:
                        driverView.Add(aPacket as DriverPacket);
                        break;
                    case NetStreamsMessageType.GUI:
                        guiView.Add(aPacket as GUIPacket);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                if(Settings.Default.LoggingEnabled) LogPacket(aPacket);
            }
            ScrollAndUpdateGrids();
        }

        private void ButtonToggleNetworkMonitor(object sender, EventArgs e) {
            if(!isRunning) StartMonitoring();
            else StopMonitoring();
            isRunning = !isRunning;
        }

        private void StartMonitoring() {
            butStartStop.Text = "Stop";
            CreateLoggers();
            theAllLogger.Info("--- START LOGGGING ---");
            theQueueTimer.Start();
            theDigiClient.Enabled = true;
        }

        private void StopMonitoring() {
            butStartStop.Text = "Start";
            theAllLogger.Info("--- STOP LOGGGING ---");
            theQueueTimer.Stop();
            theDigiClient.Enabled = false;
        }

        private void RestartMonitoring() {
            //Close existing socket
            StopMonitoring();
            ///Rebind to the currently selected network interface
            StartMonitoring();
        }

        /// <summary>
        /// Determines packet eligibility based upon whether the packet type is being logged, 
        /// if it's from the selected device, 
        /// and if it matches our active reguar expressions
        /// </summary>
        private bool WeWantToCapturePacket(NetStreamsPacket aPacket) {
            bool packetShouldBeShown = PacketTypeShouldBeCaptured(aPacket) &&
                                       PacketIsFromSelectedDevice(aPacket) &&
                                       PacketMatchesActiveRegexFilters(aPacket);
            return packetShouldBeShown;
        }

        /// <summary>
        /// Checkboxes in Data Gathering section dictate which packets are captured
        /// </summary>
        /// <param name="aPacket"></param>
        /// <returns></returns>
        private bool PacketTypeShouldBeCaptured(NetStreamsPacket aPacket) {
            bool shouldBeCaptured = true;
            switch(aPacket.MessageType) {
                case NetStreamsMessageType.Error:
                    shouldBeCaptured = Settings.Default.CaptureError;
                    break;
                case NetStreamsMessageType.Warning:
                    shouldBeCaptured = Settings.Default.CaptureWarning;
                    break;
                case NetStreamsMessageType.Info:
                    shouldBeCaptured = Settings.Default.CaptureInfo;
                    break;
                case NetStreamsMessageType.Driver:
                    shouldBeCaptured = Settings.Default.CaptureDriver;
                    break;
                case NetStreamsMessageType.GUI:
                    shouldBeCaptured = Settings.Default.CaptureGUI;
                    break;
            }
            if(Settings.Default.LogSelectedMessageTypesOnly && !shouldBeCaptured) aPacket.ShouldBeLogged = false;
            return shouldBeCaptured;
        }

        /// <summary>
        /// Matches the packet message against the selected regular expressions. 
        /// If the list of filters is empty, it satisfies this test
        /// If the packet is excluded, it is dropped immediately.
        /// If it's included, it's addded
        /// If packet is neither included or excluded, it returns true only if the include list is empty
        /// </summary>
        private bool PacketMatchesActiveRegexFilters(NetStreamsPacket aPacket) {
            Debug.WriteLine("Regex eval: " + aPacket.Message);

            if(theIncludedFilters.Count == 0 && theExcludedFilters.Count == 0) {
                Debug.WriteLine("No regex filter to include or exclude this packet, so include it");
                return true;
            } else {
                //match just one exclude and we don't want it
                if(theExcludedFilters.Exists(delegate(Filter aFilter) { return aFilter.RegularExpression.IsMatch(aPacket.Message); })) {
                    Debug.WriteLine("Excluded by filter");
                    if(Settings.Default.LogObeysFilterRules) aPacket.ShouldBeLogged = false;
                    return false;
                }
                //match just one include and it's in
                if(theIncludedFilters.Exists(delegate(Filter aFilter) { return aFilter.RegularExpression.IsMatch(aPacket.Message); })) {
                    Debug.WriteLine("Included by filter");
                    return true;
                }
            }
            if(theIncludedFilters.Count == 0) return true;
            else {
                if(Settings.Default.LogObeysFilterRules) aPacket.ShouldBeLogged = false;
                return false;
            }
        }

        /// <summary>
        /// Determines if the source of the packet is the device in the drop down list of all devices
        /// </summary>
        private bool PacketIsFromSelectedDevice(NetStreamsPacket aPacket) {
            if(cmboDevices.SelectedItem == null || (cmboDevices.SelectedItem.ToString() == "0.0.0.0")) return true;
            bool isSelectedDevice = aPacket.Device.IPAddress.ToString() == cmboDevices.SelectedItem.ToString();
            if(Settings.Default.LogObeysFilterRules && !isSelectedDevice) aPacket.ShouldBeLogged = false;
            return isSelectedDevice;
        }

        /// <summary>
        /// Add all machine IP addresses to the drop down list
        /// </summary>
        private void BindNetworkInterfaces() {
            cmbNetworkInterface.Items.Add("0.0.0.0");
            cmbNetworkInterface.Items.AddRange(Machine.AvailableIPAddresses.ToArray());
            cmbNetworkInterface.SelectedIndex = 0;
        }

        /// <summary>
        /// Instruct the DigiMulticastClient to use a specific network interface
        /// </summary>
        private void cmbNetworkInterface_SelectedIndexChanged(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(cmbNetworkInterface.Text) || theDigiClient == null) return;
            theDigiClient.BoundInterfaceIPAddress = IPAddress.Parse(cmbNetworkInterface.Text);
            if(isRunning) RestartMonitoring();
        }
    }
}