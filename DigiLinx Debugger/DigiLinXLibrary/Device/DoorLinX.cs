using System.Xml;
using DigiLinXLibrary.Device.Base;

namespace DigiLinXLibrary.Device
{
    public class DoorLinX : DigiLinxDevice
    {
        public override void LoadConfiguration(XmlNode aRootNode)
        {
            ServiceName = aRootNode.SelectSingleNode("serviceList/service[@serviceType='ui/keypad']").Attributes["serviceName"].Value;
        }
    }
}