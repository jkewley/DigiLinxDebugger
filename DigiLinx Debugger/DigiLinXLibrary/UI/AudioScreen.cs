using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI {
    internal class AudioScreen : Screen {
        private int theSettingsEnabled;

        public int SettingsEnabled { get { return theSettingsEnabled; } set { theSettingsEnabled = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<screen type="Audio" enabled="1" id="Audio" serviceName="Master Bath Player" settingsEnabled="1" />
            base.LoadConfiguration(aRootNode);
            SettingsEnabled = ParseIntAttribute("settingsEnabled", aRootNode);
        }
    }
}