using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CodingExercise
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            // Global
            bundles.Add(new ScriptBundle("~/bundles/websitejQuery").Include(
                "~/Assets/CodingExercise/Scripts/bootstrap.min.js",
                "~/Assets/CodingExercise/Scripts/jquery-1.9.1.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/websiteStyles").Include(
                "~/Assets/CodingExercise/Css/Style.css",
                "~/Assets/CodingExercise/Css/bootstrap.min.css"
                ));

        }
    }
}