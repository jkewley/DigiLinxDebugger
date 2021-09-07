using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class Dealer : ProjectEntity {
        private string theName;
        private string theNumber;
        private string theAddress;
        private string thePhone;

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<dealer name="" number="" address="" phone="" />
            theName = aRootNode.Attributes["name"].Value;
            theNumber = aRootNode.Attributes["number"].Value;
            theAddress = aRootNode.Attributes["address"].Value;
            thePhone = aRootNode.Attributes["phone"].Value;
        }

        public string Name {
            get { return theName; }
            set { theName = value; }
        }

        public string Number {
            get { return theNumber; }
            set { theNumber = value; }
        }

        public string Address {
            get { return theAddress; }
            set { theAddress = value; }
        }

        public string Phone {
            get { return thePhone; }
            set { thePhone = value; }
        }
    }
}