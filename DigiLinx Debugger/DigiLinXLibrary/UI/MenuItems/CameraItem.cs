using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI.MenuItems {
    public class CameraItem : MenuItem {
        private SortedList<int, CameraGUI> theCameras;
        private int theEnabled;
        private int theIcon;

        private int Enabled { get { return theEnabled; } set { theEnabled = value; } }
        private int Icon { get { return theIcon; } set { theIcon = value; } }
        private SortedList<int, CameraGUI> Cameras { get { return theCameras; } set { theCameras = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            // <cameras enabled="1" icon="">
            //   <camera modelNumber="Panasonic BL-C30A" port="80" image="/SnapshotJPEG?Resolution=320x240" ip="10.15.15.200" alias="Door Camera" id="Door Camera">
            //     <controls>
            //       <center url="/nphControlCamera?Direction=HomePosition" />
            //       <minus url="/nphControlCamera?Direction=ZoomWide" />
            //       <plus url="/nphControlCamera?Direction=ZoomTele" />
            //       <dn url="/nphControlCamera?Direction=TiltDown" />
            //       <up url="/nphControlCamera?Direction=TiltUp" />
            //       <right url="/nphControlCamera?Direction=PanRight" />
            //       <left url="/nphControlCamera?Direction=PanLeft" />
            //     </controls>
            //     <presets>
            //       <preset id="1" display="Upper Left" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=1" />
            //       <preset id="2" display="Upper Right" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=2" />
            //       <preset id="3" display="Lower Left" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=3" />
            //       <preset id="4" display="Lower Right" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=4" />
            //       <preset id="5" display="Preset 5" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=5" />
            //       <preset id="6" display="Preset 6" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=6" />
            //       <preset id="7" display="Preset 7" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=7" />
            //       <preset id="8" display="Preset 8" command="/nphControlCamera?Direction=Preset&amp;PresetOperation=Move&amp;Data=8" />
            //     </presets>
            //   </camera>
            // </cameras>
            base.LoadConfiguration(aRootNode);
            Enabled = ParseIntAttribute("enabled", aRootNode);
            Icon = ParseIntAttribute("icon", aRootNode);
            
            //TODO: Determine how multiple cameras are stored
            Cameras = new SortedList<int, CameraGUI>();
            int counter = 0;
            foreach(XmlNode anItemNode in aRootNode.SelectNodes("camera")) {
                CameraGUI aCamera = CameraGUI.Create(anItemNode);
                Cameras.Add(counter, aCamera);
                counter++;
            }
        }
    }
}