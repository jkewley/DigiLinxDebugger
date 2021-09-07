using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI {
    public class Menu<T> : ProjectEntityList<T> where T : MenuItem, new() {
        private int theEnabled;

        public SortedList<int, T> MenuItems { get { return theEntityList; } }
        public int Enabled { get { return theEnabled; } set { theEnabled = value; } }

        public static Menu<T> Create(XmlNode aRootNode) {
            Menu<T> aMenu = new Menu<T>();
            if(aRootNode != null) aMenu.LoadConfiguration(aRootNode);
            return aMenu;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            Enabled = ParseIntAttribute("enabled", aRootNode);
            int counter = 0;
            foreach(XmlNode anItemNode in aRootNode.SelectNodes("item")) {
                T anEntity = new T();
                anEntity.LoadConfiguration(anItemNode);
                MenuItems.Add(counter, anEntity);
                counter++;
            }
        }
    }
}