using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult SocialMediaAbout()
        {
            var values = abm.GetList();
            return PartialView();
        }
    }
}
