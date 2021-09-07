using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class Client : ProjectEntity {
        private string thePhone;
        private string theClientName;
        private string theAddress;

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<client name="Fred and Penny Abrams" address="" phone="" />
            theClientName = aRootNode.Attributes["name"].Value;
            theAddress = aRootNode.Attributes["address"].Value;
            thePhone = aRootNode.Attributes["phone"].Value;
        }

        public string Phone {
            get { return thePhone; }
        }

        public string ClientName {
            get { return theClientName; }
        }

        public string Address {
            get { return theAddress; }
        }
    }
}