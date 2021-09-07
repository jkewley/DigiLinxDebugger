using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    internal class LocationsScreen : Screen {
        private Menu<RendererMenuItem> theRendererMenu;

        private Menu<RendererMenuItem> RendererMenu { get { return theRendererMenu; } set { theRendererMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //                    <screen type="Locations" enabled="1" id="Locations">
            //                        <menu enabled="0" type="renderer">
            //                            <item roomName="Master Bath" icon="" itemnum="2" />
            //                            <item roomName="Large Patio Right" icon="" itemnum="3" />
            //                            <item roomName="Office" icon="" itemnum="4" />
            //                            <item roomName="Guest House" icon="" itemnum="5" />
            //                            <item roomName="Master Patio" icon="" itemnum="6" />
            //                            <item roomName="Bedroom One" icon="" itemnum="7" />
            //                            <item roomName="Hallway" icon="" itemnum="8" />
            //                            <item roomName="Upstairs Sitting" icon="" itemnum="9" />
            //                            <item roomName="Family" icon="" itemnum="10" />
            //                            <item roomName="Upstairs Bedroom" icon="" itemnum="11" />
            //                            <item roomName="His Closet" icon="" itemnum="12" />
            //                            <item roomName="Her Closet" icon="" itemnum="13" />
            //                            <item roomName="Bar" icon="" itemnum="14" />
            //                            <item roomName="Large Patio Left" icon="" itemnum="15" />
            //                            <item roomName="Master Bedroom" icon="" itemnum="16" />
            //                            <item roomName="Family Room Patio" icon="" itemnum="17" />
            //                            <item roomName="Exercise Room" icon="" itemnum="18" />
            //                        </menu>
            //                    </screen>
            base.LoadConfiguration(aRootNode);
            RendererMenu = Menu<RendererMenuItem>.Create(aRootNode.SelectSingleNode("menu[@type='renderer']"));
        }
    }
}