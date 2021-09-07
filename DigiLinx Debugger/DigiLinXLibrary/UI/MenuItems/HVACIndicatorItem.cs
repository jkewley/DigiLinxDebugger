using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    internal class HVACIndicatorItem : MenuItem {
        private string theField;
        private int theID;
        private string theServiceName;

        public int ID { get { return theID; } set { theID = value; } }
        public string Field { get { return theField; } set { theField = value; } }
        public string ServiceName { get { return theServiceName; } set { theServiceName = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //    <indicator id="OD-TMP" serviceName="Temp~zone1" field="T_R1S1" />
            base.LoadConfiguration(aRootNode);
            ID = ParseIntAttribute("id", aRootNode);
            ServiceName = ParseAttribute("serviceName", aRootNode);
            Field = ParseAttribute("field", aRootNode);
        }
    }
}