using System;
using System.Xml;

namespace DigiLinXLibrary.Project.Base {
    public class ProjectEntity {
        public virtual void LoadConfiguration(XmlNode aRootNode) {
            throw new ApplicationException("Virtual function call");
        }

        public string ParseAttribute(string attributeName, XmlNode node) {
            if(node.Attributes[attributeName] == null) return null;
            return node.Attributes[attributeName].Value;
        }

        public int ParseIntAttribute(string attributeName, XmlNode node) {
            if(node.Attributes[attributeName] == null) return 0;
            return int.Parse(node.Attributes[attributeName].Value);
        }

        public bool ParseBoolAttribute(string attributeName, XmlNode node) {
            return bool.Parse(node.Attributes[attributeName].Value);
        }

        public bool Parse1or0BoolAttribute(string attributeName, XmlNode node) {
            return node.Attributes[attributeName].Value == "1";
        }
    }
}