using System;
using System.Xml;
using DigiLinXLibrary.Device.Enum;
using DigiLinXLibrary.Device.Interface;

namespace DigiLinXLibrary.Device.Support {
    internal class InterfaceParser {
        public static void ParseAudioRenderer(IAudioRenderer aDevice, XmlNode aRootNode) {
            XmlNode renderer = aRootNode.SelectSingleNode("//service[@serviceType='audio/renderer']");
            aDevice.Enabled = ParseNiceBoolFrom1or0(renderer.Attributes["enabled"]);

            XmlNode defaults = renderer.SelectSingleNode("defaults");
            aDevice.DefaultBalance = ParseNiceInt(defaults.Attributes["balance"]);
            aDevice.DefaultBassLevel = ParseNiceInt(defaults.Attributes["bass"]);
            aDevice.DefaultEnabled = ParseNiceBoolFrom1or0(defaults.Attributes["enabled"]);
            aDevice.DefaultTrebleLevel = ParseNiceInt(defaults.Attributes["treble"]);
            aDevice.DefaultVolume = ParseNiceInt(defaults.Attributes["volume"]);
            aDevice.DefaultBand1 = ParseNiceInt(defaults.Attributes["band1"]);
            aDevice.DefaultBand2 = ParseNiceInt(defaults.Attributes["band2"]);
            aDevice.DefaultBand3 = ParseNiceInt(defaults.Attributes["band3"]);
            aDevice.DefaultBand4 = ParseNiceInt(defaults.Attributes["band4"]);
            aDevice.DefaultBand5 = ParseNiceInt(defaults.Attributes["band5"]);

            XmlNode output = renderer.SelectSingleNode("output");
            aDevice.Impedence = ParseNiceInt(output.Attributes["impedance"]);
            aDevice.LineOut = (LineOutMode) ParseNiceEnum(typeof(LineOutMode), output.Attributes["lineout"]);
            aDevice.StereoMode = (StereoMode) ParseNiceEnum(typeof(StereoMode), output.Attributes["stereomode"]);
            aDevice.PassThruEnabled = ParseNiceBoolFrom1or0(output.Attributes["passThru"]);
            aDevice.VolumeLimit = ParseNiceInt(output.Attributes["volumelimit"]);
            aDevice.BridgedMode = (BridgedMode) ParseNiceEnum(typeof(BridgedMode), output.Attributes["bridgedmode"]);
            aDevice.AmpDisabled = ParseNiceBoolFrom1or0(output.Attributes["ampdisabled"]);
            aDevice.RoomMate = (RoomMateMode) ParseNiceEnum(typeof(RoomMateMode), output.Attributes["roommate"]);
        }

        public static int ParseNiceInt(XmlAttribute anAttribute) {
            if(anAttribute == null) return 0;
            int result = 0;
            int.TryParse(anAttribute.Value, out result);
            return result;
        }

        public static string ParseNiceString(XmlAttribute anAttribute) {
            if(anAttribute == null) return string.Empty;
            if(string.IsNullOrEmpty(anAttribute.Value)) return string.Empty;
            return anAttribute.Value;
        }

        public static bool ParseNiceBoolFrom1or0(XmlAttribute anAttribute) {
            if(anAttribute == null) return false;
            if(string.IsNullOrEmpty(anAttribute.Value)) return false;
            return anAttribute.Value == "1";
        }

        public static object ParseNiceEnum(Type aType, XmlAttribute anAttribute) {
            if(anAttribute == null) return System.Enum.Parse(aType, System.Enum.GetNames(aType)[0]);
            if(string.IsNullOrEmpty(anAttribute.Value)) return System.Enum.Parse(aType, System.Enum.GetNames(aType)[0]);
            return System.Enum.Parse(aType, anAttribute.Value, true);
        }
    }
}