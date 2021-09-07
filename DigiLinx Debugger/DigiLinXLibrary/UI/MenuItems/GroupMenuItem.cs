using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    public class GroupMenuItem : MenuItem {
        private string theGroupName;
        private string theIcon;

        private string GroupName { get { return theGroupName; } set { theGroupName = value; } }
        private string Icon { get { return theIcon; } set { theIcon = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<item groupName="Audio_Renderers" icon="" itemnum="1" />
            base.LoadConfiguration(aRootNode);
            GroupName = ParseAttribute("groupName", aRootNode);
            Icon = ParseAttribute("icon", aRootNode);
        }
    }
}