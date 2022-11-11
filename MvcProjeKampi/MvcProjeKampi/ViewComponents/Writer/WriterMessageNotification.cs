using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
