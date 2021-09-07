using System.Xml;
using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Device.Enum;
using DigiLinXLibrary.Device.Interface;
using DigiLinXLibrary.Device.Support;

namespace DigiLinXLibrary.Device {
    public class SpeakerLinX : DigiLinxDevice, IAudioRenderer {
        private bool theAmpDisabled;
        private BridgedMode theBridgedMode;
        private int theDefaultBalance;
        private int theDefaultBand1;
        private int theDefaultBand2;
        private int theDefaultBand3;
        private int theDefaultBand4;
        private int theDefaultBand5;
        private int theDefaultBassLevel;
        private bool theDefaultEnabled;
        private int theDefaultTrebleLevel;
        private int theDefaultVolume;
        private bool theEnabled;
        private int theImpedence;
        private LineOutMode theLineOut;
        private bool thePassThruEnabled;
        private RoomMateMode theRoomMate;
        private StereoMode theStereoMode;
        private int theTemperature;
        private int theVolumeLimit;

        public int Temperature {
            get { return theTemperature; }
            set { theTemperature = value; }
        }

        #region IAudioRenderer Members

        public bool Enabled {
            get { return theEnabled; }
            set { theEnabled = value; }
        }

        public bool DefaultEnabled {
            get { return theDefaultEnabled; }
            set { theDefaultEnabled = value; }
        }

        public int DefaultVolume {
            get { return theDefaultVolume; }
            set { theDefaultVolume = value; }
        }

        public int DefaultBassLevel {
            get { return theDefaultBassLevel; }
            set { theDefaultBassLevel = value; }
        }

        public int DefaultTrebleLevel {
            get { return theDefaultTrebleLevel; }
            set { theDefaultTrebleLevel = value; }
        }

        public int DefaultBalance {
            get { return theDefaultBalance; }
            set { theDefaultBalance = value; }
        }

        public int DefaultBand1 {
            get { return theDefaultBand1; }
            set { theDefaultBand1 = value; }
        }

        public int DefaultBand2 {
            get { return theDefaultBand2; }
            set { theDefaultBand2 = value; }
        }

        public int DefaultBand3 {
            get { return theDefaultBand3; }
            set { theDefaultBand3 = value; }
        }

        public int DefaultBand4 {
            get { return theDefaultBand4; }
            set { theDefaultBand4 = value; }
        }

        public int DefaultBand5 {
            get { return theDefaultBand5; }
            set { theDefaultBand5 = value; }
        }

        public bool PassThruEnabled {
            get { return thePassThruEnabled; }
            set { thePassThruEnabled = value; }
        }

        public int Impedence {
            get { return theImpedence; }
            set { theImpedence = value; }
        }

        public int VolumeLimit {
            get { return theVolumeLimit; }
            set { theVolumeLimit = value; }
        }

        public StereoMode StereoMode {
            get { return theStereoMode; }
            set { theStereoMode = value; }
        }

        public LineOutMode LineOut {
            get { return theLineOut; }
            set { theLineOut = value; }
        }

        public BridgedMode BridgedMode {
            get { return theBridgedMode; }
            set { theBridgedMode = value; }
        }

        public bool AmpDisabled {
            get { return theAmpDisabled; }
            set { theAmpDisabled = value; }
        }

        public RoomMateMode RoomMate {
            get { return theRoomMate; }
            set { theRoomMate = value; }
        }

        #endregion

        public override void LoadConfiguration(XmlNode aRootNode) {
            ServiceName = aRootNode.SelectSingleNode("serviceList/service[@serviceType='audio/renderer']").Attributes["serviceName"].Value;
            InterfaceParser.ParseAudioRenderer(this, aRootNode);
        }
    }
}