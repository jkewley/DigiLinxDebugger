using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Xml;
using DigiLinXLibrary.Device.Base;

namespace DigiLinXLibrary.Network {
    /// <summary>
    /// Loads device information directly from the configuration files on the device itself
    /// </summary>
    public class DeviceDirectLoader {
        private static readonly Hashtable configLookup = new Hashtable();

        /// <summary>
        /// Loads the configuration information for the DigilinX device from the device itself using an Http request to config_current.xml on the device
        /// This has the potential to be very slow if the device is not available for some reason (different subnet, for example)
        /// May throw an HttpException if the device isn't found
        /// </summary>
        /// <param name="DeviceAddress">IPAddress of the DigiLinX device</param>
        /// <returns>A DigiLinxDevice with the configuration information loaded</returns>
        public static DigiLinxDevice Load(IPAddress DeviceAddress) {
            if(configLookup[DeviceAddress] != null) {
                DigiLinxDevice aDevice = (DigiLinxDevice) configLookup[DeviceAddress];
                Debug.WriteLine("Loaded config from cache for " + DeviceAddress + " [" + aDevice.ServiceName + "]");
                return aDevice;
            } else {
                if(IPIsReachable(DeviceAddress)) return LoadConfigFor(DeviceAddress);
                else {
                    Debug.WriteLine(string.Format("{0} is not reachable", DeviceAddress));
                    return LoadStub(DeviceAddress, "Unreachable");
                }
            }
        }

        /// <summary>
        /// Returns a new DigiLinXDevice without loading the configuration from the device itself. 
        /// Useful if the client is not on the same subnet as the device, meaning that the DigiLinXDevice won't be reachable
        /// </summary>
        /// <param name="DeviceAddress">IPAddress of the DigiLinX device</param>
        /// <returns>A stub representing the DigiLinxDevice, with the IPAddress set correctly and a ServiceName of Unknown</returns>
        /// <param name="aDeviceNameToUse">Name to use for the device</param>
        public static DigiLinxDevice LoadStub(IPAddress DeviceAddress, string aDeviceNameToUse) {
            DigiLinxDevice aDevice = new DigiLinxDevice();
            aDevice.ServiceName = aDeviceNameToUse;
            aDevice.DeviceName = aDeviceNameToUse;
            aDevice.IPAddress = DeviceAddress;
            configLookup[DeviceAddress] = aDevice;
            return aDevice;
        }

        /// <summary>
        /// Loads a current_config.xml from a device over HTTP
        /// </summary>
        /// <param name="aDeviceAddress">IP Address of the device</param>
        /// <returns></returns>
        public static DigiLinxDevice LoadConfigFor(IPAddress aDeviceAddress) {
            XmlDocument aDoc = new XmlDocument();
            try {
                aDoc.Load("http://" + aDeviceAddress + "/config_current.xml");
                XmlNode aDeviceNode = aDoc.SelectSingleNode(("/ns_config/system/device"));
                DigiLinxDevice aDevice = LoadConfiguration(aDeviceNode);
                aDevice.DeviceName = aDevice.ServiceName;
                aDevice.IPAddress = aDeviceAddress;
                configLookup[aDeviceAddress] = aDevice;
                Debug.WriteLine("Loaded config from device for " + aDeviceAddress + " [" + aDevice.ServiceName + "]");
                return aDevice;
            } catch(WebException) {
                //404 from a non-netstreams device
                return LoadStub(aDeviceAddress, "Unreachable");
            }
        }

        public static DigiLinxDevice LoadConfiguration(XmlNode aDeviceNode) {
            DigiLinxDevice aDevice = DigiLinxDevice.DeviceFromName(aDeviceNode.Attributes["deviceType"].Value);
            aDevice.LoadConfiguration(aDeviceNode);
            return aDevice;
        }

        /// <summary>
        /// Tries to ping an address to see if it's reachable
        /// </summary>
        /// <param name="aDeviceAddress">IP Address of the device to ping</param>
        /// <returns></returns>
        private static bool IPIsReachable(IPAddress aDeviceAddress) {
            Ping aPing = new Ping();
            Debug.WriteLine("Ping now");
            IPStatus status = aPing.Send(aDeviceAddress, 200).Status;
            Debug.WriteLine("Ping says " + status);
            return (status == IPStatus.Success);
        }
    }
}