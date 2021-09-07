using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    internal class IntercomScreen : Screen {
        private string theDefaultMic;
        private Menu<IntercomMenuItem> theMenu;
        private Menu<MonitorMenuItem> theMonitorMenu;

        private string DefaultMic { get { return theDefaultMic; } set { theDefaultMic = value; } }
        public Menu<IntercomMenuItem> IntercomMenu { get { return theMenu; } set { theMenu = value; } }
        public Menu<MonitorMenuItem> MonitorMenu { get { return theMonitorMenu; } set { theMonitorMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //                    <screen type="Intercom" defaultMic="Master Bath Intercom TL" enabled="1" id="Intercom">
            //                        <menu enabled="1" type="Intercom">
            //                            <item roomName="All Rooms" id="NS_IC_ALL" itemnum="1" />
            //                            <item roomName="Office" id="Office" itemnum="2" />
            //                            <item roomName="Guest House" id="Guest House" itemnum="3" />
            //                            <item roomName="Bedroom One" id="Bedroom One" itemnum="4" />
            //                            <item roomName="Family" id="Family" itemnum="5" />
            //                            <item roomName="Upstairs Bedroom" id="Upstairs Bedroom" itemnum="6" />
            //                        </menu>
            //                        <menu type="monitor" />
            //                    </screen>
            base.LoadConfiguration(aRootNode);
            DefaultMic = ParseAttribute("defaultMic", aRootNode);
            IntercomMenu = Menu<IntercomMenuItem>.Create(aRootNode.SelectSingleNode("menu[@type='Intercom']"));
            MonitorMenu = Menu<MonitorMenuItem>.Create(aRootNode.SelectSingleNode("menu[@type='monitor']"));
        }
    }
}