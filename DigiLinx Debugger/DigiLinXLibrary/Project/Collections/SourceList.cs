using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class SourceList : ProjectEntityList<Source> {
        public override void LoadConfiguration(XmlNode aRootNode) {
            if (aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theEntityList = new SortedList<int, Source>(aRootNode.ChildNodes.Count);
            int counter = 0;
            foreach(XmlNode aNode in aRootNode.ChildNodes) {
                theEntityList.Add(counter, Source.Create(aNode));
                counter++;
            }
        }
    }
}