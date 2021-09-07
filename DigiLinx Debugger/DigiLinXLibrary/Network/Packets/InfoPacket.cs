using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Logging;

namespace DigiLinXLibrary.Network.Packets {
    public class InfoPacket : NetStreamsPacket {
        public InfoPacket(int aSourcePort, string aMessage, string aTimeStampHex, DigiLinxDevice aDevice)
            : base(aSourcePort, aMessage, aTimeStampHex, aDevice) {
            theMessageType = NetStreamsMessageType.Info;
        }

        public override void Log(ILogger aLogger) {
            aLogger.Info(LogMessage);
        }
    }
}