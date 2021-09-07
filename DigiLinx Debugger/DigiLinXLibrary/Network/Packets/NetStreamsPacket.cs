using System;
using DigiLinXLibrary.Device.Base;
using DigiLinXLibrary.Network.Logging;

namespace DigiLinXLibrary.Network.Packets {
    public enum NetStreamsMessageType {
        Error = 1,
        Warning = 2,
        Info = 3,
        Driver = 4,
        GUI = 100
    }

    [Serializable]
    public class NetStreamsPacket {
        public bool ShouldBeLogged = true;
        private DigiLinxDevice theDevice;
        internal string theMessage;
        internal NetStreamsMessageType theMessageType;
        private int theSourcePort;
        private DateTime theTimeStamp = DateTime.Now;
        private string theTimeStampHex;

        internal NetStreamsPacket(int aPort, string aMessage, string aTimeStampHex, DigiLinxDevice aDevice) {
            theSourcePort = aPort;
            theMessage = aMessage;
            theTimeStampHex = aTimeStampHex;
            theDevice = aDevice;
        }

        public DigiLinxDevice Device { get { return theDevice; } }
        public int SourcePort { get { return theSourcePort; } }
        public string Message { get { return theMessage; } }
        public string TimeStampHex { get { return theTimeStampHex; } }
        public NetStreamsMessageType MessageType { get { return theMessageType; } }

        public string ReadableTimeStamp {
            get { return theTimeStamp.ToString("hh:mm:ss.fff"); }
            //get { return string.Format("{0}:{1}:{2}.{3}", theTimeStamp.Hour.ToString("##"), theTimeStamp.Minute.ToString("##"), theTimeStamp.Second.ToString("##"), theTimeStamp.Millisecond.ToString("###")); }
        }

        internal string LogMessage { get { return string.Format("{0}  {1}  {2}  {3}  {4}", ReadableTimeStamp, theMessageType.ToString().PadRight(10, ' '), theDevice.IPAddress.ToString().PadRight(18, ' '), theDevice.DeviceName.PadRight(20, ' '), theMessage); } }

        public virtual void Log(ILogger aLogger) {
            aLogger.Fatal(LogMessage);
        }
    }
}