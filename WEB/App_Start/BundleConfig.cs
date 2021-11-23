using System.Web;
using System.Web.Optimization;

namespace WEB
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // INDEX ///////////////////////////////////////////////////////////
            // CSS - INDEX
            bundles.Add(new StyleBundle("~/Content/Index").Include(
                      "~/Content/Global/bootstrap.css",
                      "~/Content/Global/cores.css",
                      "~/Content/Global/animate.css",
                      "~/Content/LayoutPadrao/_LayoutHome.css",
                      "~/Content/Home/index.css",
                      "~/Content/Anuncio/anuncio.css"));
            // JS -INDEX
            bundles.Add(new ScriptBundle("~/bundles/Index").Include(
                      "~/Scripts/Global/jquery-{version}.js",
                      "~/Scripts/Global/jquery.unobtrusive-ajax.js",
                      "~/Scripts/Validacao/jquery.validate*",
                      "~/Scripts/Global/bootstrap.js",
                      "~/Scripts/LayoutPadrao/_LayoutHome.js",
                      "~/Scripts/Home/index.js"));
            // METALICO ///////////////////////////////////////////////////////////
            // CSS - CORES
            bundles.Add(new StyleBundle("~/Content/Metalico").Include(
                "~/Content/Global/bootstrap.css",
                      "~/Content/Global/cores.css",
                      "~/Content/Global/animate.css",
                      "~/Content/LayoutPadrao/_LayoutHome.css",
                      "~/Content/Metalico/metalico.css",
                      "~/Content/Anuncio/anuncio.css"));
            // JS -CORES
            bundles.Add(new ScriptBundle("~/bundles/Metalico").Include(
                      "~/Scripts/Global/jquery-{version}.js",
                      "~/Scripts/Global/jquery.mask.js",
                      "~/Scripts/Global/jquery.unobtrusive-ajax.js",
                      "~/Scripts/Validacao/jquery.validate*",
                      "~/Scripts/Global/bootstrap.js",
                      "~/Scripts/LayoutPadrao/_LayoutHome.js"));
        }
    }
}
