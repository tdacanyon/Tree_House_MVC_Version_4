using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tree_House_MVC_Version_4
{
  public class MvcApplication : System.Web.HttpApplication
  {
    // We can use this method to use any code used to initialize a website.
    protected void Application_Start()
    {
      // Areas are used to group areas of large websites
      AreaRegistration.RegisterAllAreas();
      // Used to configure routs
      RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
  }
}
