using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    public class MonitorMenuItem : MenuItem {
        private string theID;
        private string theRoomName;

        private string ID { get { return theID; } set { theID = value; } }
        private string RoomName { get { return theRoomName; } set { theRoomName = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<item roomName="All Rooms" id="NS_IC_ALL" itemnum="1" />
            base.LoadConfiguration(aRootNode);
            RoomName = ParseAttribute("roomName", aRootNode);
            ID = ParseAttribute("id", aRootNode);
        }
    }
}