using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DONGDUONGPLA.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.HomePage = "";
            ViewBag.ShopPage = "";
            ViewBag.AboutPage = "";
            ViewBag.ContactPage = "active";
            return View();
        }
    }
}