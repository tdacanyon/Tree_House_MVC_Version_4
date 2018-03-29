using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tree_House_MVC_Version_4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // This makes sure that requests for .axd are never routed to one of the controls. 
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // This is the definition of the default rout. 
            routes.MapRoute(
                // This is the name of the route
                name: "Default",
                // This is the URL pattern and is defined by surrounding the parameter names with curly braces
                url: "{controller}/{action}/{id}",
                // The "Optional" here means that it will still reach a URL even 
                // if it is not defined. 
                defaults: new { controller = "SciFiBook", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
