using System.Collections.Generic;
using System.Net;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class CameraGUI : ProjectEntity {
        private string theAlias;
        private CameraControls theControls;
        private string theID;
        private string theImageUrl;
        private IPAddress theIP;
        private string theModelNumber;
        private int thePort;
        private List<CameraPreset> thePresets;

        public string ModelNumber {
            get { return theModelNumber; }
            set { theModelNumber = value; }
        }

        public int Port {
            get { return thePort; }
            set { thePort = value; }
        }

        public string ImageUrl {
            get { return theImageUrl; }
            set { theImageUrl = value; }
        }

        public IPAddress IP {
            get { return theIP; }
            set { theIP = value; }
        }

        public string Alias {
            get { return theAlias; }
            set { theAlias = value; }
        }

        public string ID {
            get { return theID; }
            set { theID = value; }
        }

        public List<CameraPreset> Presets {
            get { return thePresets; }
            set { thePresets = value; }
        }

        public CameraControls CameraControls {
            get { return theControls; }
            set { theControls = value; }
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //          <camera modelNumber="Panasonic BL-C30A" port="80" image="/SnapshotJPEG?Resolution=320x240" ip="10.15.15.200" alias="Door Camera" id="Door Camera">
            //          </camera>
            ModelNumber = aRootNode.Attributes["modelNumber"].Value;
            Port = int.Parse(aRootNode.Attributes["port"].Value);
            ImageUrl = aRootNode.Attributes["image"].Value;
            IP = IPAddress.Parse(aRootNode.Attributes["ip"].Value);
            Alias = aRootNode.Attributes["alias"].Value;
            ID = aRootNode.Attributes["id"].Value;
            CameraControls = new CameraControls(aRootNode.SelectSingleNode("controls"));
            Presets = new List<CameraPreset>();
            foreach(XmlNode aNode in aRootNode.SelectSingleNode("presets")) Presets.Add(CameraPreset.Create(aNode));
        }

        public static CameraGUI Create(XmlNode aNode) {
            CameraGUI aCameraGUI = new CameraGUI();
            aCameraGUI.LoadConfiguration(aNode);
            return aCameraGUI;
        }
    }

    public class CameraPreset : ProjectEntity {
        private string theCommand;
        private string theDisplay;
        private int theID;

        public int ID {
            get { return theID; }
            set { theID = value; }
        }

        public string Display {
            get { return theDisplay; }
            set { theDisplay = value; }
        }

        public string Command {
            get { return theCommand; }
            set { theCommand = value; }
        }

        public static CameraPreset Create(XmlNode aNode) {
            CameraPreset aPreset = new CameraPreset();
            aPreset.LoadConfiguration(aNode);
            return aPreset;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //            <presets>
            //              <preset id="1" display="Upper Left" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=1" />
            //              <preset id="2" display="Upper Right" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=2" />
            //              <preset id="3" display="Lower Left" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=3" />
            //              <preset id="4" display="Lower Right" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=4" />
            //              <preset id="5" display="Preset 5" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=5" />
            //              <preset id="6" display="Preset 6" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=6" />
            //              <preset id="7" display="Preset 7" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=7" />
            //              <preset id="8" display="Preset 8" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=8" />
            //            </presets>
            ID = int.Parse(aRootNode.Attributes["id"].Value);
            Display = aRootNode.Attributes["display"].Value;
            Command = aRootNode.Attributes["command"].Value;
        }
    }

    public class CameraControls {
        //            <controls>
        //              <center url="/nphControlCamera?Direction=HomePosition" />
        //              <minus url="/nphControlCamera?Direction=ZoomWide" />
        //              <plus url="/nphControlCamera?Direction=ZoomTele" />
        //              <dn url="/nphControlCamera?Direction=TiltDown" />
        //              <up url="/nphControlCamera?Direction=TiltUp" />
        //              <right url="/nphControlCamera?Direction=PanRight" />
        //              <left url="/nphControlCamera?Direction=PanLeft" />
        //            </controls>
        public string Center;
        public string Down;
        public string Left;
        public string Minus;
        public string Plus;
        public string Right;
        public string Up;

        public CameraControls(XmlNode aNode) {
            Center = aNode.SelectSingleNode("center").Attributes["url"].Value;
            Minus = aNode.SelectSingleNode("minus").Attributes["url"].Value;
            Plus = aNode.SelectSingleNode("plus").Attributes["url"].Value;
            Down = aNode.SelectSingleNode("dn").Attributes["url"].Value;
            Up = aNode.SelectSingleNode("up").Attributes["url"].Value;
            Left = aNode.SelectSingleNode("left").Attributes["url"].Value;
            Right = aNode.SelectSingleNode("right").Attributes["url"].Value;
        }
    }
}