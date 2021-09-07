using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project.Collections {
    public class SubscriberList : ProjectEntityList<Subscriber> {
        public override void LoadConfiguration(XmlNode aRootNode) {
            if (aRootNode != null) LoadChildren(aRootNode);
        }

        private void LoadChildren(XmlNode aRootNode) {
            theEntityList = new SortedList<int, Subscriber>(aRootNode.ChildNodes.Count);
            int counter = 0;
            foreach(XmlNode aNode in aRootNode.ChildNodes) {
                theEntityList.Add(counter, Subscriber.Create(aNode));
                counter++;
            }
        }
    }

    public class Subscriber : ProjectEntity {
        public static Subscriber Create(XmlNode aRootNode) {
            Subscriber aSubscriber = new Subscriber();
            aSubscriber.LoadConfiguration(aRootNode);
            return aSubscriber;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //TODO - need an example of this
        }
    }
}