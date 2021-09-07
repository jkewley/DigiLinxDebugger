using System;
using System.Xml;
using DigiLinXLibrary.UI.Base;

namespace DigiLinXLibrary.UI {
    public class ScreenFactory {
        public static Screen Create(XmlNode aRootNode) {
            Screen aDevice = DetermineScreenType(aRootNode);
            aDevice.LoadConfiguration(aRootNode);
            return aDevice;
        }

        private static Screen DetermineScreenType(XmlNode aRootNode) {
            if(aRootNode.Attributes["type"] != null) {
                switch(aRootNode.Attributes["type"].Value.ToLower()) {
                    case "audio":
                        return new AudioScreen();
                    case "favorites":
                        return new FavoritesScreen();
                    case "generic-serial":
                        return new GenericScreen();
                    case "intercom":
                        return new IntercomScreen();
                    case "hvac":
                        return new HVACScreen();
                    case "locations":
                        return new LocationsScreen();
                    case "panorama":
                        return new PanoramaScreen();
                    case "sources":
                        return new SourcesScreen();
                    case "zones":
                        return new ZonesScreen();
                    default:
                        throw new ApplicationException("Unknown Screen!");
                }
            } else if(aRootNode.Attributes["id"] != null && aRootNode.Attributes["id"].Value == "Cameras") {
                //<screen enabled="0" id="Cameras" />
                return new CamerasScreen();
            }
            return null;
        }
    }
}