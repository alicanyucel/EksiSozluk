using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
