using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class NonStreamNetList : ProjectEntityList<NonStreamNetDevice> {
        public override void LoadConfiguration(XmlNode aRootNode) {
            if(aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theEntityList = new SortedList<int, NonStreamNetDevice>(aRootNode.ChildNodes.Count);
            int counter = 0;
            //Audio Servers
            foreach(XmlNode aNode in aRootNode.SelectNodes("ns_audioServer")) {
                theEntityList.Add(counter, AudioServer.Create(aNode));
                counter++;
            }

            //Cameras
            foreach(XmlNode aNode in aRootNode.SelectNodes("ns_camera")) {
                theEntityList.Add(counter, Camera.Create(aNode));
                counter++;
            }
        }
    }
}