using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tree_House_MVC_Version_4.Models
{
  public class SciFiBook
  {
    public int ID { get; set; }
    public string SeriesTitle { get; set; }
    public string PullicationDate { get; set; }
    public string DescriptionHtml { get; set; }
    public Characters [] Characters { get; set; }
    public bool Favorite { get; set; }
  
  }
}