using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DigiLinXLibrary.Network.Packets;
using log4net.Config;
using NetStreamsDebugger.Properties;
using NetStreamsDebugger.Support;

namespace NetStreamsDebugger {
    public partial class DebuggerForm {
        private string loggingFolder;
        private Logger theAllLogger;
        private Logger theDriverLogger;
        private Logger theErrorLogger;
        private Logger theGUILogger;
        private Logger theInfoLogger;
        private Logger theWarningLogger;

        /// <summary>
        /// Click the link on the form to select the folder where log files should be written
        /// </summary>
        private void ClickSelectLoggingFolder(object sender, EventArgs e) {
            folderBrowserDialog.SelectedPath = loggingFolder;
            switch(folderBrowserDialog.ShowDialog()) {
                case DialogResult.OK:
                case DialogResult.Yes:
                    loggingFolder = folderBrowserDialog.SelectedPath;
                    loggingDirLabel.Text = loggingFolder;
                    Settings.Default.LogFolder = loggingFolder;
                    break;
                case DialogResult.None:
                case DialogResult.Cancel:
                case DialogResult.Abort:
                case DialogResult.Retry:
                case DialogResult.Ignore:
                case DialogResult.No:
                    return;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void EnableDisableLogging(object sender, EventArgs e) {
            chkLogOnlySelected.Enabled = chkEnableLogging.Checked;
            chkApplyFilterToLog.Enabled = chkEnableLogging.Checked;
        }

        /// <summary>
        /// Runs Windows explorer at the current logging output directory
        /// </summary>
        private void ExploreLoggingFolder(object sender, EventArgs e) {
            Process.Start("explorer.exe", Path.GetFullPath(loggingDirLabel.Text));
        }

        private void LogPacket(NetStreamsPacket thePacket) {
            if(!thePacket.ShouldBeLogged) return;
            thePacket.Log(theAllLogger);
            if(!Settings.Default.LogPerMessageType) return;

            switch(thePacket.MessageType) {
                case NetStreamsMessageType.Error:
                    thePacket.Log(theErrorLogger);
                    break;
                case NetStreamsMessageType.Warning:
                    thePacket.Log(theWarningLogger);
                    break;
                case NetStreamsMessageType.Info:
                    thePacket.Log(theInfoLogger);
                    break;
                case NetStreamsMessageType.Driver:
                    thePacket.Log(theDriverLogger);
                    break;
                case NetStreamsMessageType.GUI:
                    thePacket.Log(theGUILogger);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void CreateLoggers() {
            XmlConfigurator.Configure();
            if(theAllLogger == null) theAllLogger = new Logger();
            if(Settings.Default.LogPerMessageType) {
                if(theDriverLogger == null) theDriverLogger = new Logger("Driver");
                if(theInfoLogger == null) theInfoLogger = new Logger("Info");
                if(theWarningLogger == null) theWarningLogger = new Logger("Warn");
                if(theErrorLogger == null) theErrorLogger = new Logger("Error");
                if(theGUILogger == null) theGUILogger = new Logger("GUI");
            }
        }
    }
}