using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tree_House_MVC_Version_4.Models;
using Tree_House_MVC_Version_4.Data; 

namespace Treehouse_SciFiGallery_2.Controllers
{
  // http://localhost:53780/SciFi/Detail Here we can see that when we run MVC it calls the SciFi Controller first and then 
  // the Action Result Method which uses the "View" Method which calls the detail page through pattern matching
  public class SciFiController : Controller
  {
    private SciFiBook_Repository _sciFiBook_Repository = null;

    // Constructor
    public SciFiController()
    {
      _sciFiBook_Repository = new SciFiBook_Repository();
    }

    public ActionResult Index()
    {
      var comicBooks = _sciFiBook_Repository.GetSciFiBooksArray();
      return View(comicBooks); 
      //return Content("YO"). This is interesting in that it makes it so the index view just
      //displays "YO" regardless of what is there. 
    }
    
    // this is tricky the ? allows us to pass null (nullable types) if no int is provided
    // when the method is callled.
    public ActionResult Detail(int? id)
    {
      if (id == null)
      {
        return HttpNotFound(); 
        // This returns your 404 error
      }
      var sciFiBook = _sciFiBook_Repository.GetSiFiBook(id.Value);
      // Because we are using a nullable type we need to typ "Value" to get at the underlying value. 
      return View(sciFiBook);
    }
     // Here is your turniary operator. You need the parenthesis to make sure razor knows
      // <label> Favorite: </label> @(model.Favorite ? "Yes" : "No") </h5> 
      // here we instantiate a new instance of sciFiBook

      // View bag is an object in MVC that allows us to pass data from a controller to a view
      // View bag is one of the few real life use cases of dynamic types.
      // var type of variables are required to be initialized at the time of declaration or 
      //else they encounter the compile time error: Implicitly-typed local variables must be initialized.
      // dynamic type variables need not be initialized when declared.
      // dynamic is static and var is not. 
      // https://www.c-sharpcorner.com/UploadFile/b1df45/var-vs-dynamic-keywords-in-C-Sharp/

      // We could do this below to pass info to the view but it is not optimal
      //ViewBag.SciFiBook = sciFiBook;

    //SciFiBook jim = new SciFiBook();
   
    //public ActionResult Detail2()
    //{
    //  // here we instantiate a new instance of sciFiBook
    //  //var sciFiBook = new SciFiBook()
    //  //{
    //  //  Title = "Player of Games",
    //  //  PublicationDate = "1988",
    //  //  DescriptionHtml = " Space Chess in Space ",
    //  //  Author = " Ian M Banks ",
    //  //  Characters = new Characters[]
    //  //  {
    //  //     new Characters() {Name = "Drone: Just Read the Instructions", CharacterSketch = "Big mean mind" },
    //  //     new Characters() {Name = " Drone: Of Course I Still Lover You", CharacterSketch = "Another big mean mind" },
    //  //     new Characters() {Name = " Jernau Morat Gurgeh", CharacterSketch = "Main Character and Player of Games" },
    //  //     new Characters() {Name = " Drone Flere-Imsaho", CharacterSketch = "Jernau's companion" },
    //  //  }
    //  //};
    //  SciFiBook_Repository jim2 = new SciFiBook_Repository(); 
    //  return View(jim2.GetSiFiBook(2));
    //}
  }
}
