using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    public class SourceMenuItem : MenuItem {
        private string theControlType;
        private string theIcon;
        private string theServiceName;
        private string theSourceType;

        private string Icon { get { return theIcon; } set { theIcon = value; } }
        private string ControlType { get { return theControlType; } set { theControlType = value; } }
        private string SourceType { get { return theSourceType; } set { theSourceType = value; } }
        private string ServiceName { get { return theServiceName; } set { theServiceName = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<item serviceName="Whole House Stream" type="audio/source" controlType="NS_ARQ" sourceType="HTTP" icon="" itemnum="1" />
            //<item serviceName="Tuner" type="audio/source" controlType="SCRIPT" sourceType="TUNER" icon="" itemnum="2" />
            //<item serviceName="HD TV" type="audio/source" controlType="IR" sourceType="PVR" icon="" itemnum="3" />
            //<item serviceName="Kitchen Audio Port" type="audio/source" controlType="NOCTRL" sourceType="NOCTRL" icon="" itemnum="4" />
            //<item serviceName="Main TV Audio" type="audio/source" controlType="NOCTRL" sourceType="NOCTRL" icon="" itemnum="5" />
            //<item serviceName="Office / Master Stream" type="audio/source" controlType="NS_ARQ" sourceType="HTTP" icon="" itemnum="6" />
            //<item serviceName="Master Bedroom Audio Port" type="audio/localsource" controlType="NOCTRL" sourceType="NOCTRL" icon="" itemnum="7" />
            //<item serviceName="Outside Stream" type="audio/source" controlType="NS_ARQ" sourceType="HTTP" icon="" itemnum="8" />
            base.LoadConfiguration(aRootNode);
            ServiceName = ParseAttribute("serviceName", aRootNode);
            SourceType = ParseAttribute("type", aRootNode);
            ControlType = ParseAttribute("controlType", aRootNode);
            Icon = ParseAttribute("icon", aRootNode);
        }
    }
}