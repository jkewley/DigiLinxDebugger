using System;
using System.Net;
using System.Xml;
using DigiLinXLibrary.Device.Support;
using DigiLinXLibrary.Project;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Device.Base {
    public class DigiLinxDevice : ProjectEntity {
        private string theConfigTimeStamp;
        protected XmlNode theDeviceConfigXMLDocument;
        private string theDeviceName;
        private string theFirmwareVersion;
        private IPAddress theIPAddress;
        private string theJarNeedsUpdating;
        private string theLocation;
        private string theModelNumber;
        private NetworkInfo theNetwork;
        private string theSerialNumber;
        private string theServiceName;
        private string theSkinNeedsUpdating;
        private int theSortOrder = 1;
        private SystemInfo theSystem;

        /// <summary>
        /// Friendly formatting of "255.255.255.255 [Service Name]"
        /// </summary>
        public string IPAndName {
            get { return IPAddress + " [" + ServiceName + "]"; }
        }

        public SystemInfo SystemInfo {
            get { return theSystem; }
            set { theSystem = value; }
        }

        public string ServiceName {
            get { return theServiceName; }
            set { theServiceName = value; }
        }

        public IPAddress IPAddress {
            get { return theIPAddress; }
            set { theIPAddress = value; }
        }

        public int SortOrder {
            get { return theSortOrder; }
            set { theSortOrder = value; }
        }

        public string DeviceName {
            get { return theDeviceName; }
            set { theDeviceName = value; }
        }

        public string SerialNumber {
            get { return theSerialNumber; }
            set { theSerialNumber = value; }
        }

        public string FirmwareVersion {
            get { return theFirmwareVersion; }
            set { theFirmwareVersion = value; }
        }

        public string ModelNumber {
            get { return theModelNumber; }
            set { theModelNumber = value; }
        }

        public string Location {
            get { return theLocation; }
            set { theLocation = value; }
        }

        public string JarNeedsUpdating {
            get { return theJarNeedsUpdating; }
            set { theJarNeedsUpdating = value; }
        }

        public string SkinNeedsUpdating {
            get { return theSkinNeedsUpdating; }
            set { theSkinNeedsUpdating = value; }
        }

        public string ConfigTimeStamp {
            get { return theConfigTimeStamp; }
            set { theConfigTimeStamp = value; }
        }

        public NetworkInfo Network {
            get { return theNetwork; }
            set { theNetwork = value; }
        }

        /// <summary>
        /// Devices are considered the smae if they share the same IP address. 
        /// This could potentially lead to a bug if more than one device is created manually
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) {
            if(!(obj is DigiLinxDevice)) return false;
            return IPAddress.ToString() == ((DigiLinxDevice) obj).IPAddress.ToString();
        }

        public override string ToString() {
            return IPAddress.ToString();
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public static DigiLinxDevice DeviceFromName(string aDeviceType) {
            switch(aDeviceType) {
                case "ControlLinX":
                    return new ControlLinX();
                case "SpeakerLinX":
                    return new SpeakerLinX();
                case "TouchLinX":
                    return new TouchLinX();
                case "MediaLinX":
                    return new MediaLinX();
                case "DoorLinX":
                    return new DoorLinX();
                default:
                    throw new ApplicationException("Trying to load a device of an unknown type: " + aDeviceType);
            }
        }

        protected void InitCommonDeviceProperties() {
            theNetwork = new NetworkInfo(theDeviceConfigXMLDocument);
        }
    }
}