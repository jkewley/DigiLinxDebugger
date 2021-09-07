using System.Xml;
using DigiLinXLibrary.UI.Base;
using DigiLinXLibrary.UI.MenuItems;

namespace DigiLinXLibrary.UI {
    internal class FavoritesScreen : Screen {
        private bool theDefaultScreen;
        private Menu<FavoriteItem> theFavoritesMenu;

        private Menu<FavoriteItem> FavoritesMenu { get { return theFavoritesMenu; } set { theFavoritesMenu = value; } }
        private bool DefaultScreen { get { return theDefaultScreen; } set { theDefaultScreen = value; } }

        public override void LoadConfiguration(XmlNode aRootNode) {
            //  <screen defaultScreen="false" enabled="1" type="Favorites" id="Favorites">
            //    <favorite id="1" display="Watch HDTV" macro="Watch HDTV in Master Bath" />
            //    <favorite id="2" display="Evening" macro="Evening" />
            //    <favorite id="3" display="Kitchen MP3" macro="Kitchen MP3" />
            //    <favorite id="4" display="Good Night" macro="Good Night" />
            //  </screen>
            base.LoadConfiguration(aRootNode);
            DefaultScreen = ParseBoolAttribute("defaultScreen", aRootNode);
            theFavoritesMenu = Menu<FavoriteItem>.Create(aRootNode);
        }
    }
}