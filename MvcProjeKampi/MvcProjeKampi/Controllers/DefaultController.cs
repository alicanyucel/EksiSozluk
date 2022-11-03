using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult PartialView1()
        {
            return PartialView();
        }
    }
}
