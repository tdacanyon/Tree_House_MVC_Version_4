using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tree_House_MVC_Version_4.Models
{
  public class SciFiBook
  {
    public int ID { get; set; }
    public string Title { get; set; }
    public string PublicationDate { get; set; }
    public string DescriptionHtml { get; set; }
    public string Author { get; set; }
    public Characters[] Characters { get; set; }
    public bool Favorite { get; set; }

    public string DisplayText
      // No setter = read only. 
    {
      get
      {
        return Title+ " : " +PublicationDate;
      }
    }
    // title-publicationDate.jpg = SciFi Book image scheme
    public string CoverImageFileName
    {
      get
      {
        // For the replace the first parameter is what needs to be replaced.
        // The second parameter is what the string will be replaced with. 
        return Title.Replace(" ", "-").ToLower() + "-" + PublicationDate + ".jpg"; 
      }

    }

  }
}