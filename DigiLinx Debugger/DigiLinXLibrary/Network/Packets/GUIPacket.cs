using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Logging;

namespace DigiLinXLibrary.Network.Packets {
    public class GUIPacket : NetStreamsPacket {
        public GUIPacket(int aSourcePort, string aMessage, string aTimeStampHex, DigiLinxDevice aDevice)
            : base(aSourcePort, aMessage, aTimeStampHex, aDevice) {
            theMessageType = NetStreamsMessageType.GUI;
        }

        public override void Log(ILogger aLogger) {
            aLogger.GUI(LogMessage);
        }
    }
}