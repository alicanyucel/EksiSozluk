using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
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
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var values= bm.GetBlogListByWriter(1);
            return View(values);
        }
        
    }
}
