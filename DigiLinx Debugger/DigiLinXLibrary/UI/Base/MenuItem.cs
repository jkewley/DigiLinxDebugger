using System;
using System.Xml;
using DigiLinXLibrary.Project.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI.Base {
    public class MenuItem : ProjectEntity {
        private int theItemNumber;
        public int ItemNumber { get { return theItemNumber; } set { theItemNumber = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            ItemNumber = ParseIntAttribute("itemnum", aRootNode);
        }

        public static Type TypeFromName(string MenuItemTypeName) {
            switch(MenuItemTypeName.ToLower()) {
                case "group":
                    return typeof(GroupMenuItem);
                case "intercom":
                    return typeof(IntercomMenuItem);
                case "monitor":
                    return typeof(MonitorMenuItem);
                case "renderer":
                    return typeof(RendererMenuItem);
                case "source":
                    return typeof(SourceMenuItem);
                default:
                    throw new ApplicationException("Unknown MenuItem name: " + MenuItemTypeName.ToLower());
            }
        }
    }
}