using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
