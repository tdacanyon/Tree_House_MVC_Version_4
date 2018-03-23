using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tree_House_MVC_Version_4.Models;

namespace Treehouse_SciFiGallery_2.Controllers
{
  public class SciFiController : Controller
  {
    // The most important thing to remember here is 
    public ActionResult Detail()
    {
      // here we instantiate a new instance of sciFiBook
      var sciFiBook = new SciFiBook()
      {
        Title = " Player of Games ",
        PublicationDate = "1988",
        DescriptionHtml = " Space Chess in Space ",
        Author = " Ian M Banks ",
        Characters = new Characters[]
        {
           new Characters() {Name = "Drone: Just Read the Instructions", CharacterSketch = "Big mean mind" },
           new Characters() {Name = " Drone: Of Course I Still Lover You", CharacterSketch = "Another big mean mind" },
           new Characters() {Name = " Jernau Morat Gurgeh", CharacterSketch = "Main Character and Player of Games" },
           new Characters() {Name = " Drone Flere-Imsaho", CharacterSketch = "Jernau's companion" },
        }
      };
      var sciFiBook2 = new SciFiBook()
      {
        Title = " Seveneves ",
        PublicationDate = "2015",
        DescriptionHtml = " Moon breaks up and is not good for humans. Eventually, only 7 women are left. They restart the human race ",
        Author = " Neil Stephenson ",
        Characters = new Characters[]
        {
           new Characters() {Name = "Dinah MacQuarie:", CharacterSketch = "Roboticist working for Arjuna expeditions (a private asteroid mining company). Her robots specialize in asteroid iron mining. She decides to focus her descendants' genetics on leadership and 'heroic' qualities." },
           new Characters() {Name = " Ivy Xiao ", CharacterSketch = " Her descendants have attributes more focused on intelligence and academic study." },
           new Characters() {Name = " Julia Bliss Flaherty ", CharacterSketch = "Her descendants are more attuned to and adept at social and psychological manipulation." },
           new Characters() {Name = " Moira Crewe", CharacterSketch = "Gives only surviving child the ability to undergo epigenetic shifts in order to counter all the changes Aïda makes in her offspring." },
        }
      };

      // View bag is an object in MVC that allows us to pass data from a controller to a view
      // View bag is one of the few real life use cases of dynamic types.
      // var type of variables are required to be initialized at the time of declaration or 
      //else they encounter the compile time error: Implicitly-typed local variables must be initialized.
      // dynamic type variables need not be initialized when declared.
      // dynamic is static and var is not. 
      // https://www.c-sharpcorner.com/UploadFile/b1df45/var-vs-dynamic-keywords-in-C-Sharp/
      //ViewBag.Title = " Player of Games ";
      //ViewBag.PublicationDate = "1988";
      //ViewBag.DescriptionHtml = " Space Chess in Space ";
      //ViewBag.Author = " Ian M Banks ";
      //ViewBag.Characters = new string[]
      //{
      //" Drone: Just Read the Instructions",
      //" Drone: Of Course I Still Lover You",
      //" Jernau Morat Gurgeh ",
      //" Drone Flere-Imsaho "
      //};

      // We could do this below to pass info to the view but it is not optimal
      //ViewBag.SciFiBook = sciFiBook;

      return View(sciFiBook2);
    }
    public ActionResult Detail2()
    {
      // here we instantiate a new instance of sciFiBook
      var sciFiBook = new SciFiBook()
      {
        Title = " Player of Games ",
        PublicationDate = "1988",
        DescriptionHtml = " Space Chess in Space ",
        Author = " Ian M Banks ",
        Characters = new Characters[]
        {
           new Characters() {Name = "Drone: Just Read the Instructions", CharacterSketch = "Big mean mind" },
           new Characters() {Name = " Drone: Of Course I Still Lover You", CharacterSketch = "Another big mean mind" },
           new Characters() {Name = " Jernau Morat Gurgeh", CharacterSketch = "Main Character and Player of Games" },
           new Characters() {Name = " Drone Flere-Imsaho", CharacterSketch = "Jernau's companion" },
        }
      };
      var sciFiBook2 = new SciFiBook()
      {
        Title = " Seveneves ",
        PublicationDate = "2015",
        DescriptionHtml = " Moon breaks up and is not good for humans. Eventually, only 7 women are left. They restart the human race ",
        Author = " Neil Stephenson ",
        Characters = new Characters[]
        {
           new Characters() {Name = "Dinah MacQuarie:", CharacterSketch = "Roboticist working for Arjuna expeditions (a private asteroid mining company). Her robots specialize in asteroid iron mining. She decides to focus her descendants' genetics on leadership and 'heroic' qualities." },
           new Characters() {Name = " Ivy Xiao ", CharacterSketch = " Her descendants have attributes more focused on intelligence and academic study." },
           new Characters() {Name = " Julia Bliss Flaherty ", CharacterSketch = "Her descendants are more attuned to and adept at social and psychological manipulation." },
           new Characters() {Name = " Moira Crewe", CharacterSketch = "Gives only surviving child the ability to undergo epigenetic shifts in order to counter all the changes Aïda makes in her offspring." },
        }
      };

      return View(sciFiBook2);
    }
  }
}
