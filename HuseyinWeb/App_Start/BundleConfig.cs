using System.Web;
using System.Web.Optimization;

namespace HuseyinWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/jquery.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
               "~/Scripts/angular.js",
               "~/Scripts/angular.min.js",
               "~/Scripts/apps.js",
               "~/Scripts/Controllers/MainController.js"
               
               ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap.css",
                "~/Content/freelancer.css"));



            //bundles.Add(new StyleBundle("~/Content/mvcgrid").Include(
            //   "~/Content/Gridmvc.css"));

            //bundles.Add(new ScriptBundle("~/bundles/mvcgrid").Include(
            //    "~/Scripts/gridmvc.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}
