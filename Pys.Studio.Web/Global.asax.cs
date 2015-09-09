using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Pys.Studio.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }

        private void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
               name: "Default",
               url: "pys/{action}/{name}",
               defaults: new { controller = "Home", action = "Info" }
           );

            routes.MapRoute(
               name: "Blog",
               url: "Blog",
               defaults: new { controller = "Blog", action = "Index" }
           );

            routes.MapRoute(
            name: "ModuleDefault",
            url: "{Controller}",
            defaults: new { controller = "Home", action = "Index" }
           );

            routes.MapRoute(
            name: "ModuleInfoDefault",
            url: "{Controller}/{action}/{id}.html",
            defaults: new { action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}