using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Logging;

namespace DigiLinXLibrary.Network.Packets {
    public class DriverPacket : NetStreamsPacket {
        private string theCategory;
        private string theDriverDevice;
        private string theReducedMessage;

        public DriverPacket(int aSourcePort, string aMessage, string aTimeStampHex, DigiLinxDevice aDevice)
            : base(aSourcePort, aMessage, aTimeStampHex, aDevice) {
            theMessageType = NetStreamsMessageType.Driver;
            string[] messageParts = aMessage.Split(new char[] {':'}, 3);
            if(messageParts.Length == 3) {
                theDriverDevice = messageParts[0].Trim();
                theCategory = messageParts[1].Trim();
                theReducedMessage = messageParts[2].Trim();
            } else {
                theDriverDevice = string.Empty;
                theCategory = string.Empty;
                theReducedMessage = messageParts[0].Trim();
            }
        }

        public string DriverDevice { get { return theDriverDevice; } set { theDriverDevice = value; } }
        public string Category { get { return theCategory; } set { theCategory = value; } }
        public string ReducedMessage { get { return theReducedMessage; } set { theReducedMessage = value; } }
        public override void Log(ILogger aLogger) {
            aLogger.Driver(LogMessage);
        }
    }
}