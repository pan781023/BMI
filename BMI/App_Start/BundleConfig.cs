﻿using System.Web;
using System.Web.Optimization;

namespace BMI
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery/jquery.min.js",
                        "~/Scripts/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Scripts/jquery-easing/jquery.easing.min.js",
                        "~/Scripts/sb-admin-2.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        /*"~/Scripts/jquery.validate*"*/
                        ));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        /*"~/Scripts/modernizr-*"*/
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      /*"~/Scripts/bootstrap.js"*/
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/fontawesome-free/css/all.min.css",
                 "~/Content/css/sb-admin-2.min.css"
                      //"~/Content/bootstrap.css",
                      /*"~/Content/site.css"*/
                      ));
        }
    }
}
