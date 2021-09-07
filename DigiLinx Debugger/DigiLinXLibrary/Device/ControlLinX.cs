using System.Xml;
using DigiLinXLibrary.Device.Base;

namespace DigiLinXLibrary.Device {
    public class ControlLinX : DigiLinxDevice {
        public override void LoadConfiguration(XmlNode aRootNode) {
            ServiceName = aRootNode.SelectSingleNode("serviceList/service[@serviceType='gpio']").Attributes["serviceName"].Value;
        }
    }
}