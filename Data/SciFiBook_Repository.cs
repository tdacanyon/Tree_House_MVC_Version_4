using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tree_House_MVC_Version_4.Models;

namespace Tree_House_MVC_Version_4.Data
{
  public class SciFiBook_Repository
  {
    private static SciFiBook[] _SciFiBookArray = new SciFiBook[]
    {
      new SciFiBook()
      {
        ID = 1,
        Title = "Seveneves",
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
      },
      new SciFiBook()
      {
        ID = 2,
        Title = "Player of Games",
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
      },
       new SciFiBook()
      {
         ID = 3, 
         Title = "Red Mars",
        PublicationDate = "1992",
        DescriptionHtml = " The colonization of Mars ",
        Author = " Kim Stanly Robinson ",
        Characters = new Characters[]
        {
           new Characters() {Name = "John Boone", CharacterSketch =  "An American astronaut, who was the first human to walk on Mars in the year 2020" },
           new Characters() {Name = " Frank Chalmers ", CharacterSketch = "Head of the American contingent, he is Machiavellian in his use of power." },
        }
      }
  };
    public SciFiBook GetSiFiBook(int ID) 
    {
      SciFiBook sciFiBookToReturn = null;
      foreach (var sciFiBook in _SciFiBookArray)
      {
          if (sciFiBook.ID == ID)
        {
          sciFiBookToReturn = sciFiBook;
          break;
        }
      }
      return sciFiBookToReturn;
    }
  }
}
