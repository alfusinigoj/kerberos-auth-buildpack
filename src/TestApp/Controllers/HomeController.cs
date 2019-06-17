﻿using System;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Console.WriteLine("X-CF-Identity: " + Request.Headers.Get("X-CF-Identity"));
            Console.WriteLine("User: " + User.Identity.Name);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}