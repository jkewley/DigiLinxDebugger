using System.Xml;
using DigiLinXLibrary.Device.Base;

namespace DigiLinXLibrary.Device {
    public class MediaLinX : DigiLinxDevice {
        public override void LoadConfiguration(XmlNode aRootNode) {
            ServiceName = aRootNode.SelectSingleNode("serviceList/service[@serviceType='audio/source']").Attributes["serviceName"].Value;
        }
    }
}