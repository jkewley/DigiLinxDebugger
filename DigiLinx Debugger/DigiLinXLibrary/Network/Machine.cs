using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NetStreamsDebugger.Support {
    public class Machine {
        /// <summary>
        /// A List of IP v4 Addresses on the current machine, across all adapters.
        /// </summary>
        public static List<string> AvailableIPAddresses {
            get {
                List<string> addresses = new List<string>();
                // create collection to hold network interfaces
                NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();

                // loop through interfaces
                foreach(NetworkInterface Interface in Interfaces) {
                    // create collection to hold IP information for interfaces
                    UnicastIPAddressInformationCollection IPs = Interface.GetIPProperties().UnicastAddresses;

                    // loop through IP address collection
                    foreach(UnicastIPAddressInformation IP in IPs) {
                        // check IP address for IPv4
                        if(IP.Address.AddressFamily == AddressFamily.InterNetwork) {
                            // write IP address to debug window
                            addresses.Add(IP.Address.ToString());
                        }
                    }
                }
                return addresses;
            }
        }

        public static void AddIPAddress(string IPAddress, string SubnetMask) {
            //have to run elevated
            string enable = string.Format("netsh interface ip add address \"Local Area Connection\" {0} {1}", IPAddress, SubnetMask);
        }

        public static void RemoveIPAddress(string IPAddress) {
            //have to run elevated
            string disable = string.Format("netsh interface ip delete address \"Local Area Connection\" addr={0}", IPAddress);
        }
    }
}