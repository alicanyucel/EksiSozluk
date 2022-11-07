using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        // ekleme işlemlerinde httpget ve httpost attributeleri olan
        // metotların ismi aynı olmalıdır.
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator vm = new WriterValidator();
            ValidationResult result=vm.Validate(p);
            if (result.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "deneme test";
                wm.WriterAdd(p);

                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
                return View();
        }
    }
}
