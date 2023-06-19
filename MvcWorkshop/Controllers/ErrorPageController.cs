﻿using Microsoft.AspNetCore.Mvc;

namespace MvcWorkshop.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page403()
        {
            Response.StatusCode = 403;
            return View();
        }

        public IActionResult Page404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
