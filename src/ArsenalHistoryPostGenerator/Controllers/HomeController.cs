﻿using Microsoft.AspNetCore.Mvc;

namespace ArsenalHistoryPostGenerator.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
