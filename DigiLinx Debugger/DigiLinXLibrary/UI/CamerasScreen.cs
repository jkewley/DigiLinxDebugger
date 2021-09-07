using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    public class CamerasScreen : Screen {
        private Menu<CameraItem> theCameraMenu;
        //private SortedList<int, CameraGUI> theCameras;
        //private Menu<CameraGUI> theCameraMenu;
        //private Menu<CameraGUI> CameraMenu { get { return theCameraMenu; } set { theCameraMenu = value; } }
        //public SortedList<int, CameraGUI> Cameras { get { return theCameras; } set { theCameras = value; } }

        private Menu<CameraItem> CameraMenu { get { return theCameraMenu; } set { theCameraMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //          <screen enabled="1" id="Cameras">
            //            <cameras enabled="1" icon="">
            //              ...
            //            </cameras>
            //          </screen>
            base.LoadConfiguration(aRootNode);
            CameraMenu = Menu<CameraItem>.Create(aRootNode.SelectSingleNode("cameras"));
        }
    }
}