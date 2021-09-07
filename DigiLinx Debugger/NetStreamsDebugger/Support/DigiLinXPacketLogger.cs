using System.IO;
using DigiLinXLibrary.Network.Logging;
using log4net;
using log4net.Appender;
using log4net.Config;

namespace NetStreamsDebugger.Support {
    public class DigiLinXPacketLogger : IDigiLinXPacketLogger {
        private readonly ILogger theAllLogger;

        public DigiLinXPacketLogger() {
            XmlConfigurator.Configure();
            if(theAllLogger == null) theAllLogger = new Logger();
        }

        #region IDigiLinXPacketLogger Members

        public void LogPacket(DigiLinXLibrary.Network.Packets.NetStreamsPacket thePacket) {
            thePacket.Log(theAllLogger);
        }

        #endregion

        #region Nested type: InsarioRollingFileAppender

        public class InsarioRollingFileAppender : RollingFileAppender {
            private string theFolder;
            private string Folder { get { return theFolder; } }
            public override string File { get { return base.File; } set { base.File = Path.Combine(theFolder, value); } }
        }

        #endregion

        #region Nested type: Logger

        public class Logger : ILogger {
            private readonly ILog theLog;

            public Logger() {
                theLog = LogManager.GetLogger("DigiAllLogger");
            }

            public Logger(string byName) {
                theLog = LogManager.GetLogger(byName);
            }

            #region ILogger Members

            public void Driver(string aMessage) {
                if(theLog.IsDebugEnabled) theLog.Debug(aMessage);
            }

            public void Info(string aMessage) {
                if(theLog.IsInfoEnabled) theLog.Info(aMessage);
            }

            public void Warn(string aMessage) {
                if(theLog.IsWarnEnabled) theLog.Warn(aMessage);
            }

            public void Error(string aMessage) {
                if(theLog.IsErrorEnabled) theLog.Error(aMessage);
            }

            public void Fatal(string aMessage) {
                if(theLog.IsFatalEnabled) theLog.Fatal(aMessage);
            }

            public void GUI(string aMessage) {
                if(theLog.IsInfoEnabled) theLog.Info(aMessage);
            }

            #endregion
        }

        #endregion
    }
}