﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DONGDUONGPLA.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            ViewBag.HomePage = "";
            ViewBag.ShopPage = "";
            ViewBag.AboutPage = "active";
            ViewBag.ContactPage = "";
            return View();
        }
    }
}