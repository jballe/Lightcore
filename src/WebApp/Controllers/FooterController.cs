﻿using Microsoft.AspNet.Mvc;

namespace WebApp.Controllers
{
    public class FooterController : Controller
    {
        public ActionResult Index()
        {
            return View("/Views/Footer/Index.cshtml");
        }
    }
}