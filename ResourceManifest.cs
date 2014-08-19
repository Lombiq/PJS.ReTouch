using Orchard.UI.Resources;

namespace PJS.ReTouch {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("ThemeScript").SetUrl("script.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Isotope").SetUrl("jquery.isotope.min.js").SetVersion("1.5.25").SetDependencies("jQuery");
            manifest.DefineScript("prettyPhoto").SetUrl("jquery.prettyPhoto.min.js").SetVersion("3.1.5").SetDependencies("jQuery");
            manifest.DefineScript("Slider-Revolution-Plugins").SetUrl("rs-plugin/jquery.themepunch.plugins.min.js").SetVersion("4.5.6").SetDependencies("jQuery");
            manifest.DefineScript("Slider-Revolution").SetUrl("rs-plugin/jquery.themepunch.revolution.min.js").SetVersion("4.5.6").SetDependencies("Slider-Revolution-Plugins");
            manifest.DefineScript("Styler").SetUrl("jquery.styler.js").SetDependencies("jQuery");

            manifest.DefineStyle("ThemeStyle").SetUrl("style.min.css");
            manifest.DefineStyle("prettyPhoto").SetUrl("prettyPhoto.css");
            manifest.DefineStyle("Slider-Revolution-Settings").SetUrl("rs-plugin/css/settings.css").SetVersion("4.1.1");
            manifest.DefineStyle("Slider-Revolution-Dynamic-Captions").SetUrl("rs-plugin/css/dynamic-captions.css").SetVersion("4.1.1").SetDependencies("Slider-Revolution-Settings");
            manifest.DefineStyle("Slider-Revolution-Static-Captions").SetUrl("rs-plugin/css/static-captions.css").SetVersion("4.1.1").SetDependencies("Slider-Revolution-Settings");
        }
    }
}
