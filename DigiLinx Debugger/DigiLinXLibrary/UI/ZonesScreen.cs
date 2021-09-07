using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    internal class ZonesScreen : Screen {
        private Menu<GroupMenuItem> theGroupMenu;

        private Menu<GroupMenuItem> GroupMenu { get { return theGroupMenu; } set { theGroupMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            // <screen type="Zones" enabled="1" id="Zones">
            //   <menu enabled="1" type="group">
            //     <item groupName="Audio_Renderers" icon="" itemnum="1" />
            //     <item groupName="All Rooms" icon="" itemnum="1" />
            //     <item groupName="Inside Common Area" icon="" itemnum="2" />
            //     <item groupName="Watch TV" icon="" itemnum="3" />
            //   </menu>
            // </screen>
            base.LoadConfiguration(aRootNode);
            GroupMenu = Menu<GroupMenuItem>.Create(aRootNode.SelectSingleNode("menu[@type='group']"));
        }
    }
}