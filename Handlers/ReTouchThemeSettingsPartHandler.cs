using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using PJS.ReTouch.Models;

namespace PJS.ReTouch.Handlers {
    [UsedImplicitly]
    public class ReTouchThemeSettingsPartHandler : ContentHandler {
        public ReTouchThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<ReTouchThemeSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<ReTouchThemeSettingsPart>("ReTouchThemeSettings", "Parts/ReTouchThemeSettings", "Theme-ReTouch"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme-ReTouch")));
        }
    }
}