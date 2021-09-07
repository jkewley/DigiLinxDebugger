using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class GUI : ProjectEntity {
        private string theSchema;
        private string theTimeStamp;
        public RoomList theRooms;
        public CameraGUIList theCameras;
        public SourceList theSources;
        public DoorLinXGUIList theDoorLinXGUIList;
        public MacroList theMacros;

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<gui timeStamp="1182304524833" schema="0.3">
            theSchema = aRootNode.Attributes["schema"].Value;
            theTimeStamp = aRootNode.Attributes["timeStamp"].Value;
            if (aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theRooms = new RoomList();
            theCameras = new CameraGUIList();
            theSources = new SourceList();
            theDoorLinXGUIList = new DoorLinXGUIList();
            theMacros = new MacroList();
            theRooms.LoadConfiguration(aRootNode.SelectSingleNode("rooms"));
            theCameras.LoadConfiguration(aRootNode.SelectSingleNode("cameras"));
            theSources.LoadConfiguration(aRootNode.SelectSingleNode("sources"));
            theDoorLinXGUIList.LoadConfiguration(aRootNode.SelectSingleNode("doorlinxs"));
            theMacros.LoadConfiguration(aRootNode.SelectSingleNode("macros"));
        }

        public string Schema {
            get { return theSchema; }
            set { theSchema = value; }
        }

        public string TimeStamp {
            get { return theTimeStamp; }
            set { theTimeStamp = value; }
        }
    }
}