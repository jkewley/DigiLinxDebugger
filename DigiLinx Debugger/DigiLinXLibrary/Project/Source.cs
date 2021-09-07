using System.Xml;
using DigiLinXLibrary.Project.Base;

namespace DigiLinXLibrary.Project {
    public class Source : ProjectEntity {
        private string theServiceName;
        private string theControlType;
        private string theSourceType;
        private string theNSType;
        private string theIcon;
        private string theItemNum;

        public static Source Create(XmlNode aNode) {
            Source aSource = new Source();
            aSource.LoadConfiguration(aNode);
            return aSource;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<source serviceName="Fam" controlType="NS_FIREBALL" sourceType="HTTP" type="audio/source" icon="" itemnum="7" />
            ServiceName = aRootNode.Attributes["serviceName"].Value;
            ControlType = aRootNode.Attributes["controlType"].Value;
            SourceType = aRootNode.Attributes["sourceType"].Value;
            NSType = aRootNode.Attributes["type"].Value;
            Icon = aRootNode.Attributes["icon"].Value;
            ItemNum = aRootNode.Attributes["itemnum"].Value;
        }

        public string ServiceName {
            get { return theServiceName; }
            set { theServiceName = value; }
        }

        public string ControlType {
            get { return theControlType; }
            set { theControlType = value; }
        }

        public string SourceType {
            get { return theSourceType; }
            set { theSourceType = value; }
        }

        public string NSType {
            get { return theNSType; }
            set { theNSType = value; }
        }

        public string Icon {
            get { return theIcon; }
            set { theIcon = value; }
        }

        public string ItemNum {
            get { return theItemNum; }
            set { theItemNum = value; }
        }
    }
}