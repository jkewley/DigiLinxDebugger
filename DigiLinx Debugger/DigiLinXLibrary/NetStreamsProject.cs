using DigiLinXLibrary.Project;
using DigiLinXLibrary.Project.Collections;

namespace DigiLinXLibrary {
    public class NetStreamsProject {
        private Client theClient;
        private Dealer theDealer;
        private string theDealerSetupVersion;
        private GroupList theGroups;
        private GUI theGUI;
        private MacroList theMacros;
        private NonStreamNetList theNonStreamNet;
        private string theProjectName;
        private SubscriberList theSubscribers;
        private SystemList theSystemList;

        public NetStreamsProject() {
            theClient = new Client();
            theDealer = new Dealer();
            theSystemList = new SystemList();
            theGUI = new GUI();
            theGroups = new GroupList();
            theNonStreamNet = new NonStreamNetList();
            theSubscribers = new SubscriberList();
            theMacros = new MacroList();
        }

        public string ProjectName {
            get { return theProjectName; }
            set { theProjectName = value; }
        }

        public string DealerSetupVersion {
            get { return theDealerSetupVersion; }
            set { theDealerSetupVersion = value; }
        }

        public Client Client {
            get { return theClient; }
            set { theClient = value; }
        }

        public Dealer Dealer {
            get { return theDealer; }
            set { theDealer = value; }
        }

        public GUI GUI {
            get { return theGUI; }
            set { theGUI = value; }
        }

        public GroupList Groups {
            get { return theGroups; }
            set { theGroups = value; }
        }

        public NonStreamNetList NonStreamNet {
            get { return theNonStreamNet; }
            set { theNonStreamNet = value; }
        }

        public SubscriberList Subscribers {
            get { return theSubscribers; }
            set { theSubscribers = value; }
        }

        public MacroList Macros {
            get { return theMacros; }
            set { theMacros = value; }
        }

        public SystemList SystemList {
            get { return theSystemList; }
            set { theSystemList = value; }
        }
    }
}