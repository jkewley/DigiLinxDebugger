using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    public class HVACScreen : Screen {
        private Menu<HVACIndicatorItem> theHVACControlMenu;
        private int theTermostatID;

        private Menu<HVACIndicatorItem> HVACControlMenu { get { return theHVACControlMenu; } set { theHVACControlMenu = value; } }
        private int TermostatID { get { return theTermostatID; } set { theTermostatID = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //  <screen id="Temp" type="hvac" serviceName="Temp~zone1" enabled="1">
            //      <indicators thermostat="1">
            //          <indicator id="OD-TMP" serviceName="Temp~zone1" field="T_R1S1" />
            //          <indicator id="OD-HUM" serviceName="Temp~zone2" field="H_R1S1" />
            //          <indicator id="ID-TMP" serviceName="Temp~zone1" field="temperature" />
            //          <indicator id="ID-HUM" serviceName="Temp~zone1" field="humidity" />
            //      </indicators>
            //  </screen>
            base.LoadConfiguration(aRootNode);
            TermostatID = ParseIntAttribute("thermostat", aRootNode);
            HVACControlMenu = Menu<HVACIndicatorItem>.Create(aRootNode.SelectSingleNode("tvControls"));
        }
    }
}