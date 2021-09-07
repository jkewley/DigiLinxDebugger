using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.UI.Base {
    public class Screen : ProjectEntity {
        private int theEnabled = 0;
        private string theID;
        private string theServiceName;

        public string ID { get { return theID; } set { theID = value; } }
        public int Enabled { get { return theEnabled; } set { theEnabled = value; } }
        public string ServiceName { get { return theServiceName; } set { theServiceName = value; } }

        public override void LoadConfiguration(System.Xml.XmlNode aRootNode) {
            Enabled = ParseIntAttribute("enabled", aRootNode);
            ID = ParseAttribute("id", aRootNode);
            ServiceName = ParseAttribute("serviceName", aRootNode);
        }

    }
}