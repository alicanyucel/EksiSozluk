using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
