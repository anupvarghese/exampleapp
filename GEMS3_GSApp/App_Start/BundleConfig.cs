using System.Web;
using System.Web.Optimization;

namespace GEMS3_GSApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bowerjs")
                // bower:js
                
                
                
                .Include("~/Content/bower_components/jquery/dist/jquery.js")
                .Include("~/Content/bower_components/bootstrap/dist/js/bootstrap.js")
                .Include("~/Content/bower_components/respond/dest/respond.src.js")
                .Include("~/Content/bower_components/jquery-validate/dist/jquery.validate.js")
                .Include("~/Content/bower_components/kendo-ui/js/kendo.all.min.js")
                // endbower
                );

            bundles.Add(new StyleBundle("~/bundles/bowercss")
                // bower:css

                .Include("~/Content/bower_components/bootstrap/dist/css/bootstrap.css", new CssRewriteUrlTransform())
                .Include("~/Content/bower_components/kendo-ui/styles/kendo.common-bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/bower_components/kendo-ui/styles/kendo.default.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/bower_components/kendo-ui/styles/kendo.bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/bower_components/kendo-ui/styles/kendo.dataviz.bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/bower_components/kendo-ui/styles/kendo.dataviz.default.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/bower_components/fontawesome/css/font-awesome.css", new CssRewriteUrlTransform())
                // endbower
                .Include("~/Content/Site.css")
                );

              //bundles.Add(new StyleBundle("~/bundles/kendo-ui")
              //  // bower:css
              //  //.Include("~/Content/bower_components/kendo-ui/styles/kendo.default.min.css")
              //  //.Include("~/Content/bower_components/kendo-ui/styles/kendo.dataviz.default.min.css")
              //  .Include("~/Content/bower_components/kendo-ui/styles/kendo.common-bootstrap.min.css")  
              //  .Include("~/Content/bower_components/kendo-ui/styles/kendo.bootstrap.min.css")                              
              //  .Include("~/Content/bower_components/kendo-ui/styles/kendo.dataviz.bootstrap.min.css")
              //   );
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
