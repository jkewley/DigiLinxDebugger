using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class CameraGUIList : ProjectEntityList<CameraGUI> {
        private int theEnabled;
        private string theIcon;

        public int Enabled { get { return theEnabled; } set { theEnabled = value; } }

        public string Icon { get { return theIcon; } set { theIcon = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            // <cameras enabled="1" icon="">
            theEnabled = int.Parse(aRootNode.Attributes["enabled"].Value);
            theIcon = aRootNode.Attributes["icon"].Value;
            if (aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theEntityList = new SortedList<int, CameraGUI>(aRootNode.ChildNodes.Count);
            int counter = 1;
            foreach (XmlNode aNode in aRootNode.ChildNodes) {
                theEntityList.Add(counter, CameraGUI.Create(aNode));
                counter++;
            }
        }
    }
}