using System.Xml;
using DigiLinXLibrary.Project.Base;
using DigiLinXLibrary.Project.Collections;

namespace DigiLinXLibrary.Project {
    /// <summary>
    /// Contains system information and a list of devices, located at /ns_project/streamnet/systemList
    /// </summary>
    public class SystemList : ProjectEntity {
        private DeviceInfoList theDeviceInfoList;
        private SystemInfo theSystemInfo;

        public SystemList() {
            theSystemInfo = new SystemInfo();
            theDeviceInfoList = new DeviceInfoList();
        }

        public SystemInfo SystemInfo {
            get { return theSystemInfo; }
            set { theSystemInfo = value; }
        }

        public DeviceInfoList DeviceInfoList {
            get { return theDeviceInfoList; }
            set { theDeviceInfoList = value; }
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            theSystemInfo.LoadConfiguration(aRootNode.SelectSingleNode("systemInfo"));
            theDeviceInfoList.LoadConfiguration(aRootNode.SelectSingleNode("deviceList"));
        }
    }
}