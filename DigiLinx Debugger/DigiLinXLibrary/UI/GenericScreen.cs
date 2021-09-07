using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    public class GenericScreen : Screen {
        private Menu<ButtonItem> theButtonMenu;

        private Menu<ButtonItem> ButtonMenu { get { return theButtonMenu; } set { theButtonMenu = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //          <screen enabled="0" serviceName="Demo" type="generic-serial" id="Demo">
            //            <buttons>
            //              <button id="1" itemNum="1" serviceName="Demo~1" display="a" />
            //              <button id="2" itemNum="2" serviceName="Demo~2" display="b" />
            //            </buttons>
            //          </screen>

            base.LoadConfiguration(aRootNode);
            ButtonMenu = Menu<ButtonItem>.Create(aRootNode.SelectSingleNode("buttons/button"));
        }
    }
}