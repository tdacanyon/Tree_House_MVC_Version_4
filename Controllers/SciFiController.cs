using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Treehouse_SciFiGallery_2.Controllers
{

  public class SciFiController : Controller
  {


    public ActionResult Detail()

    {
      // View bag is an object in MVC that allows us to pass data from a controller to a view
      // View bag is one of the few real life use cases of dynamic types.
      // var type of variables are required to be initialized at the time of declaration or 
      //else they encounter the compile time error: Implicitly-typed local variables must be initialized.
      // dynamic type variables need not be initialized when declared.
      // dynamic is static and var is not. 
      // https://www.c-sharpcorner.com/UploadFile/b1df45/var-vs-dynamic-keywords-in-C-Sharp/
      ViewBag.BookName = " Player of Games ";
      ViewBag.PublicationDate = "1988";
      ViewBag.Description = " Space Chess ";
      ViewBag.Author = " Ian M Banks ";
      ViewBag.Characters = new string[]
      {
      " Drone: Just Read the Instructions",
      " Drone: Of Course I Still Lover You",
      " Jernau Morat Gurgeh ",
      " Drone Flere-Imsaho "
      };

      return View();
    }
  }
}
