using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    internal class PanoramaScreen : Screen {
        private Menu<TVControlItem> theTVControlMenu;

        private Menu<TVControlItem> TVControlMenu { get { return theTVControlMenu; } set { theTVControlMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //          <screen type="Panorama" enabled="1" id="Panorama" serviceName="Panorama">
            //            <tvControls>
            //              <control id="1" display="Power" />
            //              <control id="2" display="Vol Up" />
            //              <control id="3" display="Vol Dn" />
            //              <control id="4" display="Source" />
            //              <control id="5" display="Mute" />
            //              <control id="6" display="Aspect Ratio" />
            //            </tvControls>
            //          </screen>
            base.LoadConfiguration(aRootNode);
            TVControlMenu = Menu<TVControlItem>.Create(aRootNode.SelectSingleNode("tvControls"));
        }
    }
}