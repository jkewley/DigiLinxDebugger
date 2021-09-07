using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;
using DigiLinXLibrary.Project.Collections;

namespace DigiLinXLibrary.Project {
    public class Service : ProjectEntity {
        private int theEnabled;
        private GroupList theGroups;
        private PresetList thePresets;
        private RoomList theRooms;
        private string theServiceName;
        private int theServiceNumber;
        private string theServiceType;
        private SubscriberList theSubscribers;

        public int ServiceNumber { get { return theServiceNumber; } set { theServiceNumber = value; } }

        public int Enabled { get { return theEnabled; } set { theEnabled = value; } }

        public string ServiceType { get { return theServiceType; } set { theServiceType = value; } }

        public string ServiceName { get { return theServiceName; } set { theServiceName = value; } }

        public SubscriberList Subscribers { get { return theSubscribers; } set { theSubscribers = value; } }

        public GroupList Groups { get { return theGroups; } set { theGroups = value; } }

        public PresetList Presets { get { return thePresets; } set { thePresets = value; } }

        public RoomList Rooms { get { return theRooms; } set { theRooms = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //    <service serviceName="default" serviceNumber="4" serviceType="root" enabled="1">
            //        <rooms>
            //            <room roomName="default" />
            //        </rooms>
            //        <groups>
            //            <group groupName="ALL" />
            //        </groups>
            //        <presets />
            //        <subscribers />
            //    </service>
            ServiceName = aRootNode.Attributes["serviceName"].Value;
            ServiceNumber = int.Parse(aRootNode.Attributes["serviceNumber"].Value);
            ServiceType = aRootNode.Attributes["serviceType"].Value;
            Enabled = int.Parse(aRootNode.Attributes["enabled"].Value);
            ParseChildren(aRootNode);
        }

        private void ParseChildren(XmlNode aRootNode) {
            theGroups = new GroupList();
            thePresets = new PresetList();
            theRooms = new RoomList();

//            XmlNodeList screenList = aRootNode.SelectNodes("screens/screen/");
//            int counter = 0;
//            foreach (XmlNode aScreen in screenList) {
//                theGroups.LoadConfiguration();
//                counter++;
//            }
        }
    }
}