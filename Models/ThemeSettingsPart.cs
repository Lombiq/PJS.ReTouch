using Orchard.ContentManagement;

namespace PJS.ReTouch.Models {
    public class ThemeSettingsPart : ContentPart {
        public string Skin {
            get { return this.Retrieve(r => r.Skin, Constants.SkinDefault); }
            set { this.Store(r => r.Skin, value); }
        }
        public bool UseHoverMenus {
            get { return this.Retrieve(r => r.UseHoverMenus, false); }
            set { this.Store(r => r.UseHoverMenus, value); }
        }
    }
}