using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class DoorLinXGUI : ProjectEntity {
        private string theID;
        private string thePrimaryCamera;
        private string theCamera2;
        private string theCamera3;
        private string theCamera4;
        private int theRelayDelay;
        private string theRelay;

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<doorlinx id="Front Door" primaryCamera="" camera2="" camera3="" camera4="" relayDelay="3" relay="Front Door GPIO" />
            ID = aRootNode.Attributes["id"].Value;
            PrimaryCamera = aRootNode.Attributes["primaryCamera"].Value;
            Camera2 = aRootNode.Attributes["camera2"].Value;
            Camera3 = aRootNode.Attributes["camera3"].Value;
            Camera4 = aRootNode.Attributes["camera4"].Value;
            RelayDelay = int.Parse(aRootNode.Attributes["relayDelay"].Value);
            Relay = aRootNode.Attributes["relay"].Value;
        }

        public string ID {
            get { return theID; }
            set { theID = value; }
        }

        public string PrimaryCamera {
            get { return thePrimaryCamera; }
            set { thePrimaryCamera = value; }
        }

        public string Camera2 {
            get { return theCamera2; }
            set { theCamera2 = value; }
        }

        public string Camera3 {
            get { return theCamera3; }
            set { theCamera3 = value; }
        }

        public string Camera4 {
            get { return theCamera4; }
            set { theCamera4 = value; }
        }

        public int RelayDelay {
            get { return theRelayDelay; }
            set { theRelayDelay = value; }
        }

        public string Relay {
            get { return theRelay; }
            set { theRelay = value; }
        }

        public static DoorLinXGUI Create(XmlNode aNode) {
            DoorLinXGUI aDXGUI = new DoorLinXGUI();
            aDXGUI.LoadConfiguration(aNode);
            return aDXGUI;
        }
    }
}