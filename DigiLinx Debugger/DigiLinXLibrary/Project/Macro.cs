using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class Macro : ProjectEntity {
        private string theName;
        private string theDescription;
        private SortedList<int, MacroStep> theSteps;

        public static Macro Create(XmlNode aNode) {
            Macro aMacro = new Macro();
            aMacro.LoadConfiguration(aNode);
            return aMacro;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //          <macro desc="Turns on main TV audio in house" name="Listen to Main TV">
            //            <steps>
            //              <step label="Create MultiRoom Session (All Rooms MultiRoom)" data="#@Audio_Renderers#MULTIAUDIO JOIN {{All Rooms MultiRoom}}" />
            //              <step label="Set Volume of All Audio Players to 60" data="#@Audio_Renderers#LEVEL_SET VOL {{60}}" />
            //              <step label="Change Source of All Audio Players to Main TV" data="#@Audio_Renderers#SRC_SEL {{Main TV}}" />
            //              <step label="Jump to MultiRoom Screen of All Rooms UI" data="#@All~UI#CHANGE_SCREEN {{multi-room}}" />
            //            </steps>
            //          </macro>
            Description = aRootNode.Attributes["desc"].Value;
            Name = aRootNode.Attributes["name"].Value;
            Steps = new SortedList<int, MacroStep>(aRootNode.SelectNodes("steps/step").Count);
            LoadSteps(aRootNode);
        }

        private void LoadSteps(XmlNode aRootNode) {
            XmlNodeList steps = aRootNode.SelectNodes("steps/step");
            int counter = 0;
            foreach(XmlNode aScreen in steps) {
                Steps.Add(counter, new MacroStep(aScreen.Attributes["label"].Value, aScreen.Attributes["data"].Value));
                counter++;
            }
        }

        public string Name {
            get { return theName; }
            set { theName = value; }
        }

        public string Description {
            get { return theDescription; }
            set { theDescription = value; }
        }

        public SortedList<int, MacroStep> Steps {
            get { return theSteps; }
            set { theSteps = value; }
        }
    }

    public class MacroStep {
        private string theLabel;
        private string theData;

        public MacroStep(string aLabel, string someData) {
            theLabel = aLabel;
            theData = someData;
        }

        public string Label {
            get { return theLabel; }
            set { theLabel = value; }
        }

        public string Data {
            get { return theData; }
            set { theData = value; }
        }
    }
}