﻿using Microsoft.AspNetCore.Mvc;

namespace UpSchoolAkbank_CapStone.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
