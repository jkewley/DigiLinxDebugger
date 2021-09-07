using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class GroupList : ProjectEntityList<GroupGUI> {
        public override void LoadConfiguration(XmlNode aRootNode) {
            if (aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theEntityList = new SortedList<int, GroupGUI>(aRootNode.ChildNodes.Count);
            int counter = 0;
            foreach(XmlNode aNode in aRootNode.ChildNodes) {
                theEntityList.Add(counter, GroupGUI.Create(aNode));
                counter++;
            }
        }
    }

    public class GroupGUI : ProjectEntity {
        private string theName;

        public string Name { get { return theName; } set { theName = value; } }

        public static GroupGUI Create(XmlNode aRootNode) {
            GroupGUI aGroupGUI = new GroupGUI();
            aGroupGUI.LoadConfiguration(aRootNode);
            return aGroupGUI;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<group name="ALL" />
            Name = aRootNode.Attributes["name"].Value;
        }
    }
}