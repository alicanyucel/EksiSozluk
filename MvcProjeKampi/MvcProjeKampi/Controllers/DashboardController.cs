﻿using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
