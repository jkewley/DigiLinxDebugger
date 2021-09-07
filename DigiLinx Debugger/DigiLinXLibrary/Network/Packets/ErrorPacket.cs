using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Logging;

namespace DigiLinXLibrary.Network.Packets {
    public class ErrorPacket : NetStreamsPacket {
        public ErrorPacket(int aSourcePort, string aMessage, string aTimeStampHex, DigiLinxDevice aDevice)
            : base(aSourcePort, aMessage, aTimeStampHex, aDevice) {
            theMessageType = NetStreamsMessageType.Error;
        }

        public override void Log(ILogger aLogger) {
            aLogger.Error(LogMessage);
        }
    }
}