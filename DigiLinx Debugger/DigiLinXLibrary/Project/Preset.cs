using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class Preset : ProjectEntity {
        public static Preset Create(XmlNode aRootNode) {
            Preset aPreset = new Preset();
            aPreset.LoadConfiguration(aRootNode);
            return aPreset;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {}
    }
}