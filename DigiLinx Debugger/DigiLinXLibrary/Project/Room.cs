using System.Collections.Generic;
using System.Xml;
using DigiLinXLibrary.Project.Base;
using DigiLinXLibrary.UI;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.Project {
    public class Room : ProjectEntity {
        private SortedList<int, Screen> theScreens;
        private string theID;
        private int thePrivacy = 0;
        private string thePressedColor;
        private string theSkinName;
        private string theNetStreamsType;
        private string theFirmware;
        private string theDefaultColor;
        private string theIconColor;
        private string theTextColor;
        private string theMainBGColor;

        public static Room Create(XmlNode aRootNode) {
            Room aRoom = new Room();
            aRoom.LoadConfiguration(aRootNode);
            return aRoom;
        }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //<room id="Master Bath" privacy="0" skinName="Monet 5" type="designer" firmware="02_22_2007" defaultColor="0066CC" 
            //pressedColor="55AC2B" iconColor="FFFFFF" textColor="FFFFFF" mainBGColor="0066CC">
            theID = ParseAttribute("id",aRootNode);
            thePrivacy = ParseIntAttribute("privacy",aRootNode);
            SkinName = ParseAttribute("skinName",aRootNode);
            NetStreamsType = ParseAttribute("type",aRootNode);
            Firmware = ParseAttribute("firmware",aRootNode);
            DefaultColor = ParseAttribute("defaultColor",aRootNode);
            PressedColor = ParseAttribute("pressedColor",aRootNode);
            IconColor = ParseAttribute("iconColor",aRootNode);
            TextColor = ParseAttribute("textColor",aRootNode);
            MainBGColor = ParseAttribute("mainBGColor", aRootNode);
            LoadScreens(aRootNode);
        }

        private void LoadScreens(XmlNode aRootNode) {
            theScreens = new SortedList<int, Screen>();
            XmlNodeList screenList = aRootNode.SelectNodes("screens/screen");
            int counter = 0;
            foreach(XmlNode aScreen in screenList) {
                theScreens.Add(counter, ScreenFactory.Create(aScreen));
                counter++;
            }
        }

        public string ID {
            get { return theID; }
            set { theID = value; }
        }

        public int Privacy {
            get { return thePrivacy; }
            set { thePrivacy = value; }
        }

        public string PressedColor {
            get { return thePressedColor; }
            set { thePressedColor = value; }
        }

        public string SkinName {
            get { return theSkinName; }
            set { theSkinName = value; }
        }

        public string NetStreamsType {
            get { return theNetStreamsType; }
            set { theNetStreamsType = value; }
        }

        public string Firmware {
            get { return theFirmware; }
            set { theFirmware = value; }
        }

        public string DefaultColor {
            get { return theDefaultColor; }
            set { theDefaultColor = value; }
        }

        public string IconColor {
            get { return theIconColor; }
            set { theIconColor = value; }
        }

        public string TextColor {
            get { return theTextColor; }
            set { theTextColor = value; }
        }

        public string MainBGColor {
            get { return theMainBGColor; }
            set { theMainBGColor = value; }
        }
    }
}