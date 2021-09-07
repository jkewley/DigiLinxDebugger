using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Device;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class DeviceInfoList : ProjectEntityList<DigiLinxDeviceInfo> {
        public override void LoadConfiguration(XmlNode aRootNode) {
            //<deviceInfo type="SpeakerLinX" deviceName="Master Bath SL" serialNumber="SL250A0631400116100F2AC" firmwareVersion="01.40.03" modelNumber="SL250A" location="" jarNeedsUpdating="0" skinNeedsUpdating="0">
            //<ns_config timeStamp="1178379052703">
            //<system projectName="Estancia" systemName="Audio Distribution" defaultIPPort="7000" adminIPAddr="0.0.0.0" adminSubNetMask="255.255.255.0" adminIPPort="5000" systemMulticastAddr="239.255.16.90" systemMulticastPort="5001" autoDiscoveryPort="8000" commandServerPort="15000" autoIPRange="192.168.0.2:192.168.0.99" streamMulticastAddrPool="239.255.17.1:239.255.48.255" streamMulticastPortPool="5002:15000">
            if(aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theEntityList = new SortedList<int, DigiLinxDeviceInfo>(aRootNode.ChildNodes.Count);
            int counter = 0;
            foreach(XmlNode aNode in aRootNode.ChildNodes) {
                theEntityList.Add(counter, DigiLinxDeviceInfo.Create(aNode));
                counter++;
            }
        }

        public void SortByName() {
            SortedList<string, DigiLinxDeviceInfo> aNewList = new SortedList<string, DigiLinxDeviceInfo>();
            foreach(KeyValuePair<int, DigiLinxDeviceInfo> entry in theEntityList)
                aNewList.Add(entry.Value.DeviceName, entry.Value);

            theEntityList.Clear();
            int counter = 0;
            foreach(KeyValuePair<string, DigiLinxDeviceInfo> entry in aNewList) {
                theEntityList.Add(counter, entry.Value);
                counter++;
            }
        }
    }
}