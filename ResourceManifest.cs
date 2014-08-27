using Orchard.UI.Resources;

namespace PJS.ReTouch {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("ThemeScript").SetUrl("script.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Isotope").SetUrl("jquery.isotope.min.js").SetVersion("1.5.25").SetDependencies("jQuery");
            manifest.DefineScript("prettyPhoto").SetUrl("jquery.prettyPhoto.min.js").SetVersion("3.1.5").SetDependencies("jQuery");

            manifest.DefineStyle("ThemeStyle").SetUrl("style.min.css");
            manifest.DefineStyle("prettyPhoto").SetUrl("prettyPhoto.css");
        }
    }
}
