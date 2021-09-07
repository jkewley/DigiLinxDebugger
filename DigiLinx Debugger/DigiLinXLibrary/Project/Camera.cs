using System.Collections.Generic;
using System.Net;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class Camera : NonStreamNetDevice {
        private CameraDeviceInfo theTheCameraDeviceInfo;
        private string theTheCameraType;
        private string theType = "Camera";

        public string theCameraType {
            get { return theTheCameraType; }
            set { theTheCameraType = value; }
        }

        public CameraDeviceInfo theCameraDeviceInfo {
            get { return theTheCameraDeviceInfo; }
            set { theTheCameraDeviceInfo = value; }
        }

        public string Type {
            get { return theType; }
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<ns_camera type="Camera" cameraType="Panasonic BL-C30A">
            theType = ParseAttribute("type", aRootNode);
            theCameraType = ParseAttribute("cameraType", aRootNode);
            theCameraDeviceInfo = new CameraDeviceInfo();
            theTheCameraDeviceInfo.LoadConfiguration(aRootNode.SelectSingleNode("deviceInfo"));
        }

        public static Camera Create(XmlNode aNode) {
            Camera camera = new Camera();
            camera.LoadConfiguration(aNode);
            return camera;
        }
    }

    public class CameraDeviceInfo : ProjectEntity {
        private CameraControls theControls;
        private string theDeviceName;
        private string theImage;
        private IPAddress theIP;
        private string theMenuAlias;
        private string theModelNumber;
        private int thePort;
        private List<CameraPreset> thePresets;
        private string theShowNGUI;

        public string ModelNumber {
            get { return theModelNumber; }
            set { theModelNumber = value; }
        }

        public int Port {
            get { return thePort; }
            set { thePort = value; }
        }

        public string Image {
            get { return theImage; }
            set { theImage = value; }
        }

        public IPAddress IP {
            get { return theIP; }
            set { theIP = value; }
        }

        public string DeviceName {
            get { return theDeviceName; }
            set { theDeviceName = value; }
        }

        public List<CameraPreset> Presets {
            get { return thePresets; }
            set { thePresets = value; }
        }

        public CameraControls CameraControls {
            get { return theControls; }
            set { theControls = value; }
        }

        public string MenuAlias {
            get { return theMenuAlias; }
            set { theMenuAlias = value; }
        }

        public string ShowNGUI {
            get { return theShowNGUI; }
            set { theShowNGUI = value; }
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //    <deviceInfo deviceName="Door Camera" modelNumber="Panasonic BL-C30A" IP="10.15.15.200" menuAlias="Door Camera" showNGui="1" image="/SnapshotJPEG?Resolution=320x240" port="80">
            DeviceName = ParseAttribute("deviceName", aRootNode);
            ModelNumber = ParseAttribute("modelNumber", aRootNode);
            IP = IPAddress.Parse(ParseAttribute("IP", aRootNode));
            MenuAlias = ParseAttribute("menuAlias", aRootNode);
            ShowNGUI = ParseAttribute("showNGui", aRootNode);
            Image = aRootNode.Attributes["image"].Value;
            Port = ParseIntAttribute("port", aRootNode);

            CameraControls = new CameraControls(aRootNode.SelectSingleNode("controls"));
            Presets = new List<CameraPreset>();
            foreach(XmlNode aNode in aRootNode.SelectSingleNode("presets")) Presets.Add(CameraPreset.Create(aNode));
        }
    }
}