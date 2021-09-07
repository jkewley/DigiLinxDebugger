using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    internal class TVControlItem : MenuItem {
        private string theDisplay;
        private int theID;

        private int ID { get { return theID; } set { theID = value; } }
        private string Display { get { return theDisplay; } set { theDisplay = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<control id="1" display="Power" />
            base.LoadConfiguration(aRootNode);
            Display = ParseAttribute("display", aRootNode);
            ID = ParseIntAttribute("id", aRootNode);
        }
    }
}