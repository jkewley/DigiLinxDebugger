using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    internal class SourcesScreen : Screen {
        private Menu<SourceMenuItem> theSourcesMenu;
        //<screen type="Sources" enabled="1" id="Sources">
        //    <menu enabled="0" type="Source">
        //        <item serviceName="Dining" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="1" />
        //        <item serviceName="Directv One" type="audio/source" controlType="IR" sourceType="PVR" icon="" itemnum="2" />
        //        <item serviceName="Directv Three" type="audio/source" controlType="IR" sourceType="PVR" icon="" itemnum="3" />
        //        <item serviceName="Directv Two" type="audio/source" controlType="IR" sourceType="PVR" icon="" itemnum="4" />
        //        <item serviceName="Escient" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="5" />
        //        <item serviceName="Escient Media Center" type="audio/source" controlType="IR" sourceType="TRNSPRT" icon="" itemnum="6" />
        //        <item serviceName="Fam" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="7" />
        //        <item serviceName="Fam Patio" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="8" />
        //        <item serviceName="Guest" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="9" />
        //        <item serviceName="Hall" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="10" />
        //        <item serviceName="Her" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="11" />
        //        <item serviceName="His" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="12" />
        //        <item serviceName="Home Gym" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="13" />
        //        <item serviceName="Home Office" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="14" />
        //        <item serviceName="Kit" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="15" />
        //        <item serviceName="Living" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="16" />
        //        <item serviceName="Living Bar" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="17" />
        //        <item serviceName="M Patio" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="18" />
        //        <item serviceName="M. Bath" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="19" />
        //        <item serviceName="M. Bed" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="20" />
        //        <item serviceName="Patio Left" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="21" />
        //        <item serviceName="Patio Right" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="22" />
        //        <item serviceName="Up. Bed" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="23" />
        //        <item serviceName="Up. Sitting" type="audio/source" controlType="NS_FIREBALL" sourceType="HTTP" icon="" itemnum="24" />
        //    </menu>
        //</screen>

        private Menu<SourceMenuItem> SourcesMenu { get { return theSourcesMenu; } set { theSourcesMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            base.LoadConfiguration(aRootNode);
            SourcesMenu = Menu<SourceMenuItem>.Create(aRootNode.SelectSingleNode("menu[@type='Source']"));
        }
    }
}