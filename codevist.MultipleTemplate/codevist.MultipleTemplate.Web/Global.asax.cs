using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using codevist.MultipleTemplate.Web.Models;

namespace codevist.MultipleTemplate.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterViewEngine(ViewEngines.Engines);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public static void RegisterViewEngine(ViewEngineCollection viewEngines)
        {
            // mevcut engineleri temizliyoruz.
            viewEngines.Clear();

            var basePath = ConfigurationManager.AppSettings["ThemeBasePath"];
            var themeName = ConfigurationManager.AppSettings["ThemeName"];

            var theme = new ThemeModel(basePath, themeName);

            var themeableRazorViewEngine = new ThemeRazorViewEngine(theme);

            viewEngines.Add(themeableRazorViewEngine);
        }
    }
}
