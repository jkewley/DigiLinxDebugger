using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    public class RendererMenuItem : MenuItem {
        private string theIcon;
        private string theRoomName;

        private string RoomName { get { return theRoomName; } set { theRoomName = value; } }

        private string Icon { get { return theIcon; } set { theIcon = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<item roomName="Master Bath" icon="" itemnum="2" />
            base.LoadConfiguration(aRootNode);
            RoomName = ParseAttribute("roomName", aRootNode);
            Icon = ParseAttribute("icon", aRootNode);
        }
    }
}