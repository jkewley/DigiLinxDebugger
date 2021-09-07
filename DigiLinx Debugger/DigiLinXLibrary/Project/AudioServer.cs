using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class AudioServer : NonStreamNetDevice {
        private AudioServerDeviceInfo theDeviceInfo;
        private AudioServerType theServerType;

        public AudioServerType ServerType {
            get { return theServerType; }
            set { theServerType = value; }
        }

        public AudioServerDeviceInfo DeviceInfo {
            get { return theDeviceInfo; }
            set { theDeviceInfo = value; }
        }

        public static AudioServer Create(XmlNode aRootNode) {
            AudioServer aNonStreamNet = new AudioServer();
            aNonStreamNet.LoadConfiguration(aRootNode);
            return aNonStreamNet;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //        <ns_audioServer type="AudioRequest">
            //            <deviceInfo deviceName="Media Server" serialNumber="ARQ402821" modelNumber="F2-Pro" daemonVersion="" firmwareVersion="2.2.7">
            //                <network staticIP="10.15.15.10" subnetMask="" gatewayIP="" DNS_IP="" staticIP_EN="1" DHCP_EN="1" mediaPort="80" controlPort="80" directoryServerPort="8081">
            //                    <streams maxStreams="6">
            //                        <stream name="Casita Stream" deviceName="Master Bath SL" serviceNumber="2" enabled="0" />
            //                        <stream name="Outside Stream" deviceName="Back Porch SL" serviceNumber="2" enabled="1" />
            //                        <stream name="Office / Master Stream" deviceName="Master Bedroom SL" serviceNumber="2" enabled="1" />
            //                        <stream name="Guest Stream" deviceName="Laundry SL" serviceNumber="2" enabled="1" />
            //                        <stream name="Whole House Stream" deviceName="Casita SL" serviceNumber="2" enabled="1" />
            //                    </streams>
            //                </network>
            //            </deviceInfo>
            //        </ns_audioServer>
            ServerType = (AudioServerType) Enum.Parse(typeof(AudioServerType), aRootNode.Attributes["type"].Value, true);
            DeviceInfo = new AudioServerDeviceInfo(aRootNode.SelectSingleNode("deviceInfo"));
        }
    }

    public class AudioServerDeviceInfo : ProjectEntity {
        private string theDaemonVersion;
        private string theDeviceName;
        private string theFirmwareVersion;
        private string theModelNumber;
        private AudioServerNetworkInfo theNetworkInfo;
        private string theSerialNumber;

        public AudioServerDeviceInfo(XmlNode aNode) {
            DeviceName = ParseAttribute("deviceName", aNode);
            SerialNumber = ParseAttribute("serialNumber", aNode);
            FirmwareVersion = ParseAttribute("firmwareVersion", aNode);
            DaemonVersion = ParseAttribute("daemonVersion", aNode);
            ModelNumber = ParseAttribute("modelNumber", aNode);
            NetworkInfo = new AudioServerNetworkInfo(aNode.SelectSingleNode("network"));
        }

        public AudioServerNetworkInfo NetworkInfo {
            get { return theNetworkInfo; }
            set { theNetworkInfo = value; }
        }

        public string FirmwareVersion {
            get { return theFirmwareVersion; }
            set { theFirmwareVersion = value; }
        }

        public string DaemonVersion {
            get { return theDaemonVersion; }
            set { theDaemonVersion = value; }
        }

        public string ModelNumber {
            get { return theModelNumber; }
            set { theModelNumber = value; }
        }

        public string SerialNumber {
            get { return theSerialNumber; }
            set { theSerialNumber = value; }
        }

        public string DeviceName {
            get { return theDeviceName; }
            set { theDeviceName = value; }
        }
    }

    public class AudioServerNetworkInfo : ProjectEntity {
        private int? theControlPort;
        private bool theDHCPEnabled;
        private int? theDirectoryServerPort;
        private string theDNSIP;
        private string theGateway;
        private int? theMediaPort;
        private bool theStaticEnabled;
        private IPAddress theStaticIP;
        private StreamList theStreamList;
        private string theSubnet;

        public AudioServerNetworkInfo(XmlNode aNode) {
            DirectoryServerPort = ParseIntAttribute("directoryServerPort", aNode);
            ControlPort = ParseIntAttribute("controlPort", aNode);
            MediaPort = ParseIntAttribute("mediaPort", aNode);
            DHCPEnabled = Parse1or0BoolAttribute("DHCP_EN", aNode);
            StaticEnabled = Parse1or0BoolAttribute("staticIP_EN", aNode);
            DNSIP = ParseAttribute("DNS_IP", aNode);
            Gateway = ParseAttribute("gatewayIP", aNode);
            Subnet = ParseAttribute("subnetMask", aNode);
            StaticIP = IPAddress.Parse(ParseAttribute("staticIP", aNode));
            theStreamList = new StreamList(aNode.SelectSingleNode("streams"));
        }

        public StreamList StreamList {
            get { return theStreamList; }
            set { theStreamList = value; }
        }

        public int? DirectoryServerPort {
            get { return theDirectoryServerPort; }
            set { theDirectoryServerPort = value; }
        }

        public int? ControlPort {
            get { return theControlPort; }
            set { theControlPort = value; }
        }

        public int? MediaPort {
            get { return theMediaPort; }
            set { theMediaPort = value; }
        }

        public bool DHCPEnabled {
            get { return theDHCPEnabled; }
            set { theDHCPEnabled = value; }
        }

        public bool StaticEnabled {
            get { return theStaticEnabled; }
            set { theStaticEnabled = value; }
        }

        public string DNSIP {
            get { return theDNSIP; }
            set { theDNSIP = value; }
        }

        public string Gateway {
            get { return theGateway; }
            set { theGateway = value; }
        }

        public string Subnet {
            get { return theSubnet; }
            set { theSubnet = value; }
        }

        public IPAddress StaticIP {
            get { return theStaticIP; }
            set { theStaticIP = value; }
        }
    }

    public class StreamList : ProjectEntity {
        private int theMaxStreams;
        private List<AudioServerStream> theStreams;

        public StreamList(XmlNode aNode) {
            MaxStreams = ParseIntAttribute("maxStreams", aNode);
            theStreams = new List<AudioServerStream>();
            foreach(XmlNode node in aNode.SelectNodes("stream")) {
                AudioServerStream aStream = new AudioServerStream();
                aStream.Name = ParseAttribute("name", node);
                aStream.DeviceName = ParseAttribute("deviceName", node);
                aStream.ServiceNumber = ParseIntAttribute("serviceNumber", node);
                aStream.Enabled = Parse1or0BoolAttribute("enabled", node);
                theStreams.Add(aStream);
            }
        }

        public List<AudioServerStream> Streams {
            get { return theStreams; }
            set { theStreams = value; }
        }

        public int MaxStreams {
            get { return theMaxStreams; }
            set { theMaxStreams = value; }
        }
    }

    public class AudioServerStream : ProjectEntity {
        private string theDeviceName;
        private bool theEnabled;
        private string theName;
        private int theServiceNumber;

        public bool Enabled {
            get { return theEnabled; }
            set { theEnabled = value; }
        }

        public int ServiceNumber {
            get { return theServiceNumber; }
            set { theServiceNumber = value; }
        }

        public string DeviceName {
            get { return theDeviceName; }
            set { theDeviceName = value; }
        }

        public string Name {
            get { return theName; }
            set { theName = value; }
        }
    }

    public enum AudioServerType {
        AudioRequest,
        FireBall
    }
}