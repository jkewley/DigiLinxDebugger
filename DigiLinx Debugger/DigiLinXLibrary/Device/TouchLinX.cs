using System.Xml;
using DigiLinXLibrary.Device.Base;

namespace DigiLinXLibrary.Device {
    public class TouchLinX : DigiLinxDevice {
        public override void LoadConfiguration(XmlNode aRootNode) {
            ServiceName = aRootNode.SelectSingleNode("serviceList/service[@serviceType='ui/flash']").Attributes["serviceName"].Value;
        }
    }
}