using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Logging;

namespace DigiLinXLibrary.Network.Packets {
    public class WarningPacket : NetStreamsPacket {
        public WarningPacket(int aSourcePort, string aMessage, string aTimeStampHex, DigiLinxDevice aDevice)
            : base(aSourcePort, aMessage, aTimeStampHex, aDevice) {
            theMessageType = NetStreamsMessageType.Warning;
        }

        public override void Log(ILogger aLogger) {
            aLogger.Warn(LogMessage);
        }
    }
}