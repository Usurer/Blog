using System.Web;
using System.Web.Optimization;

namespace Blog
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /* SCRIPTS */

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/vendor/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/vendor/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/vendor/bootstrap.js",
                "~/Scripts/vendor/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/tinymce").Include(
                "~/Scripts/vendor/tinymce/tinymce.min.js",
                "~/Scripts/vendor/tinymce/themes/modern/theme.min.js",
                "~/Scripts/js/tinymceInit.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/js/contentEditor.js",
                "~/Scripts/js/app.js",
                "~/Scripts/js/testTypeScript.js"));

            /* STYLES */

            bundles.Add(new StyleBundle("~/Styles/css").Include(
                "~/Styles/css/bootstrap.css",
                "~/Styles/css/layout.css"));
        }
    }
}
