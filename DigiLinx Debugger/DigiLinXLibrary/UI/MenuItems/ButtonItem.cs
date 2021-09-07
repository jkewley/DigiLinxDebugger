using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    public class ButtonItem : MenuItem {
        private string theDisplay;
        private string theID;
        private string theServiceName;

        private string ID { get { return theID; } set { theID = value; } }
        private string ServiceName { get { return theServiceName; } set { theServiceName = value; } }
        private string Display { get { return theDisplay; } set { theDisplay = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<button id="1" itemNum="1" serviceName="Demo~1" display="a" />
            base.LoadConfiguration(aRootNode);
            ID = ParseAttribute("id", aRootNode);
            ServiceName = ParseAttribute("serviceName", aRootNode);
            Display = ParseAttribute("display", aRootNode);
        }
    }
}