using Microsoft.AspNetCore.Mvc;
using MvcProjeKampi.Models;
using System.Collections.Generic;

namespace MvcProjeKampi.ViewComponents
{
    public class CommentList:ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            var commnetValues = new List<UserComment>
            {
                new UserComment{Id=1,Name="alican"},
                new UserComment{Id=2,Name="birolcan"},
                new UserComment{Id=3,Name="muratcab"},
                new UserComment{Id=4,Name="velican"}
            };
            return View(commnetValues);
        }
    }
}
