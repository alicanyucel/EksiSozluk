using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class Blog : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository()); 
        public IActionResult Index()
        {
            var values = bm.GetBlockWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values = bm.GetBlogById(id);
            return View(values);
        }
    }
}
