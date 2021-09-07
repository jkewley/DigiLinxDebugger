using System.Net;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    /// <summary>
    /// System Information for a DigiLinX Project, located at /ns_project/streamnet/systemList/systemInfo
    /// </summary>
    public class SystemInfo : ProjectEntity {
        private IPAddress theAdminIPAddress;
        private int theAdminPort;
        private IPAddress theAdminSubnetMask;
        private int theAutoDiscoveryPort;
        private string theAutoIpRange;
        private int theCommandServerPort;
        private int theDefaultPort;
        private IPAddress theGateway;
        private string theProjectName;
        private string theStreamMulticastAddressPool;
        private string theStreamMulticastPortPool;
        private IPAddress theSystemMulticastIPAddress;
        private IPAddress theSystemMulticastSubnetMask;
        private string theSystemName;

        public IPAddress Gateway {
            get { return theGateway; }
            set { theGateway = value; }
        }

        public string ProjectName {
            get { return theProjectName; }
            set { theProjectName = value; }
        }

        public string SystemName {
            get { return theSystemName; }
            set { theSystemName = value; }
        }

        public int DefaultPort {
            get { return theDefaultPort; }
            set { theDefaultPort = value; }
        }

        public IPAddress AdminIPAddress {
            get { return theAdminIPAddress; }
            set { theAdminIPAddress = value; }
        }

        public IPAddress AdminSubnetMask {
            get { return theAdminSubnetMask; }
            set { theAdminSubnetMask = value; }
        }

        public int AdminPort {
            get { return theAdminPort; }
            set { theAdminPort = value; }
        }

        public IPAddress SystemMulticastIPAddress {
            get { return theSystemMulticastIPAddress; }
            set { theSystemMulticastIPAddress = value; }
        }

        public IPAddress SystemMulticastSubnetMask {
            get { return theSystemMulticastSubnetMask; }
            set { theSystemMulticastSubnetMask = value; }
        }

        public int AutoDiscoveryPort {
            get { return theAutoDiscoveryPort; }
            set { theAutoDiscoveryPort = value; }
        }

        public int CommandServerPort {
            get { return theCommandServerPort; }
            set { theCommandServerPort = value; }
        }

        public string AutoIpRange {
            get { return theAutoIpRange; }
            set { theAutoIpRange = value; }
        }

        public string StreamMulticastAddressPool {
            get { return theStreamMulticastAddressPool; }
            set { theStreamMulticastAddressPool = value; }
        }

        public string StreamMulticastPortPool {
            get { return theStreamMulticastPortPool; }
            set { theStreamMulticastPortPool = value; }
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<systemInfo gateway="0.0.0.0" projectName="New Project" systemName="Audio Distribution" 
            //defaultIPPort="7000" adminIPAddr="0.0.0.0" adminSubNetMask="255.255.255.0" adminIPPort="5000" 
            //systemMulticastAddr="239.255.16.90" systemMulticastPort="5001" autoDiscoveryPort="8000" 
            //commandServerPort="15000" autoIPRange="192.168.0.2:192.168.0.99" streamMulticastAddrPool="239.255.17.1:239.255.48.255" 
            //streamMulticastPortPool="5002:15000" />
            theGateway = IPAddress.Parse(aRootNode.Attributes["gateway"].Value);
            theProjectName = aRootNode.Attributes["projectName"].Value;
            theSystemName = aRootNode.Attributes["systemName"].Value;
            theDefaultPort = int.Parse(aRootNode.Attributes["defaultIPPort"].Value);
            theAdminIPAddress = IPAddress.Parse(aRootNode.Attributes["adminIPAddr"].Value);
            theAdminSubnetMask = IPAddress.Parse(aRootNode.Attributes["adminSubNetMask"].Value);
            theAdminPort = int.Parse(aRootNode.Attributes["adminIPPort"].Value);
            theSystemMulticastIPAddress = IPAddress.Parse(aRootNode.Attributes["systemMulticastAddr"].Value);
            theSystemMulticastSubnetMask = IPAddress.Parse(aRootNode.Attributes["systemMulticastPort"].Value);
            theAutoDiscoveryPort = int.Parse(aRootNode.Attributes["autoDiscoveryPort"].Value);
            theCommandServerPort = int.Parse(aRootNode.Attributes["commandServerPort"].Value);
            theAutoIpRange = aRootNode.Attributes["autoIPRange"].Value;
            theStreamMulticastAddressPool = aRootNode.Attributes["streamMulticastAddrPool"].Value;
            theStreamMulticastPortPool = aRootNode.Attributes["streamMulticastPortPool"].Value;
        }
    }
}