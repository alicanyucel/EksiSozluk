using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
