using System.Web.Optimization;

namespace JobBoard.MVC.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/jquery.min.js",
                      "~/Scripts/js/popper.min.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/jquery.cookie.js",
                      "~/Scripts/js/jquery.waypoints.min.js",
                      "~/Scripts/js/jquery.counterup.min.js",
                      "~/Scripts/js/owl.carousel.min.js",
                      "~/Scripts/js/owl.carousel2.thumbs.min.js",
                      "~/Scripts/js/jquery.parallax-1.1.3.js",
                      "~/Scripts/js/bootstrap-select.min.js",
                      "~/Scripts/js/jquery.scrollTo.min.js",
                      "~/Scripts/js/front.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/bootstrap-select.min.css",
                      "~/Content/css/owl.carousel.css",
                      "~/Content/css/owl.theme.default.css",
                      "~/Content/css/style.default.css",
                      "~/Content/css/custom.css"));
        }
    }
}
