using System.IO;
using DigiLinXLibrary.Network.Logging;
using log4net;
using log4net.Appender;
using NetStreamsDebugger.Properties;

namespace NetStreamsDebugger.Support {
    public class Logger : ILogger {
        private readonly ILog theLog;

        public Logger() {
            theLog = LogManager.GetLogger(typeof(DebuggerForm));
        }

        public Logger(string byName) {
            theLog = LogManager.GetLogger(byName);
        }

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
    }

    public class InsarioRollingFileAppender : RollingFileAppender {
        public override string File { get { return base.File; } set { base.File = Path.Combine(Settings.Default.LogFolder, value); } }
    }
}