﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DONGDUONGPLA.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            ViewBag.HomePage = "";
            ViewBag.ShopPage = "active";
            return View();
        }
    }
}