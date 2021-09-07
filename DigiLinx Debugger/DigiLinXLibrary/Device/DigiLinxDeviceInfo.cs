using System.Xml;
using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Device {
    /// <summary>
    /// Wrapper class for a DigiLinXDevice, only found in a project file.
    /// This information is not available when reading a config_current.xml from a device directly.
    /// </summary>
    public class DigiLinxDeviceInfo : ProjectEntity {
        private string theConfigTimeStamp;
        private string theDeviceName;
        private DigiLinxDevice theDigiLinXDevice;
        private string theFirmwareVersion;
        private string theJarNeedsUpdating;
        private string theLocation;
        private string theModelNumber;
        private string theSerialNumber;
        private string theSkinNeedsUpdating;

        public string DeviceName {
            get { return theDeviceName; }
            set { theDeviceName = value; }
        }

        public string FirmwareVersion {
            get { return theFirmwareVersion; }
            set { theFirmwareVersion = value; }
        }

        public string JarNeedsUpdating {
            get { return theJarNeedsUpdating; }
            set { theJarNeedsUpdating = value; }
        }

        public string Location {
            get { return theLocation; }
            set { theLocation = value; }
        }

        public string ModelNumber {
            get { return theModelNumber; }
            set { theModelNumber = value; }
        }

        public string SerialNumber {
            get { return theSerialNumber; }
            set { theSerialNumber = value; }
        }

        public string SkinNeedsUpdating {
            get { return theSkinNeedsUpdating; }
            set { theSkinNeedsUpdating = value; }
        }

        public string ConfigTimeStamp {
            get { return theConfigTimeStamp; }
            set { theConfigTimeStamp = value; }
        }

        public DigiLinxDevice DigiLinXDevice {
            get { return theDigiLinXDevice; }
        }

        public static DigiLinxDeviceInfo Create(XmlNode aDeviceNode) {
            DigiLinxDeviceInfo anInfo = new DigiLinxDeviceInfo();
            anInfo.LoadConfiguration(aDeviceNode);
            return anInfo;
        }

        public override void LoadConfiguration(XmlNode aDeviceNode) {
            //deviceInfo type="SpeakerLinX" deviceName="Master Bath SL" serialNumber="SL250A0631400116100F2AC" firmwareVersion="01.40.03" modelNumber="SL250A" location="" jarNeedsUpdating="0" skinNeedsUpdating="0">
            DeviceName = aDeviceNode.Attributes["deviceName"].Value;
            FirmwareVersion = aDeviceNode.Attributes["firmwareVersion"].Value;
            JarNeedsUpdating = aDeviceNode.Attributes["jarNeedsUpdating"].Value;
            Location = aDeviceNode.Attributes["location"].Value;
            ModelNumber = aDeviceNode.Attributes["modelNumber"].Value;
            SerialNumber = aDeviceNode.Attributes["serialNumber"].Value;
            SkinNeedsUpdating = aDeviceNode.Attributes["skinNeedsUpdating"].Value;
            ConfigTimeStamp = aDeviceNode.SelectSingleNode("ns_config").Attributes["timeStamp"].Value;
            theDigiLinXDevice = DigiLinxDevice.DeviceFromName(aDeviceNode.SelectSingleNode("ns_config/system/device/@deviceType").Value);
            DigiLinXDevice.LoadConfiguration(aDeviceNode.SelectSingleNode("ns_config/system/device"));
        }
    }
}