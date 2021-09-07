using System.Net;
using System.Xml;

namespace DigiLinXLibrary.Device.Support {
    public class NetworkInfo {
        private int theDHCPEnabled;
        private IPAddress theGateway;
        private IPAddress theIP;
        private IPAddress theIPMask;
        private int theStaticIPEnabled;

        public NetworkInfo(XmlNode aDocument) {
            XmlNode theNetworkNode = aDocument.SelectSingleNode("ns_config/system/device/network");
            theDHCPEnabled = int.Parse(theNetworkNode.Attributes["DHCP_EN"].Value);
            theStaticIPEnabled = int.Parse(theNetworkNode.Attributes["staticIP_EN"].Value);
            theIP = IPAddress.Parse(theNetworkNode.Attributes["IP"].Value);
            theIPMask = IPAddress.Parse(theNetworkNode.Attributes["IPMask"].Value);
            theGateway = IPAddress.Parse(theNetworkNode.Attributes["gatewayIP"].Value);
        }

        public int DHCPEnabled {
            get { return theDHCPEnabled; }
            set { theDHCPEnabled = value; }
        }

        public int StaticIPEnabled {
            get { return theStaticIPEnabled; }
            set { theStaticIPEnabled = value; }
        }

        public IPAddress IP {
            get { return theIP; }
            set { theIP = value; }
        }

        public IPAddress IPMask {
            get { return theIPMask; }
            set { theIPMask = value; }
        }

        public IPAddress Gateway {
            get { return theGateway; }
            set { theGateway = value; }
        }
    }
}