using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    internal class FavoriteItem : MenuItem {
        private string theDisplay;
        private int theID;
        private string theMacro;

        public int ID { get { return theID; } set { theID = value; } }
        private string Display { get { return theDisplay; } set { theDisplay = value; } }
        /// <summary>
        /// Pointer to a Macro.Name
        /// </summary>
        private string Macro { get { return theMacro; } set { theMacro = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //    <favorite id="1" display="Watch HDTV" macro="Watch HDTV in Master Bath" />
            base.LoadConfiguration(aRootNode);
            ID = ParseIntAttribute("id", aRootNode);
            Display = ParseAttribute("display", aRootNode);
            Macro = ParseAttribute("macro", aRootNode);
        }
    }
}