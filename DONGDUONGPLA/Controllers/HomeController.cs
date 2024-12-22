using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DONGDUONGPLA.Models;


namespace DONGDUONGPLA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string tenHH)
        {
            Hshop2023Entities1 db = new Hshop2023Entities1();
            List<HangHoa> lsv = db.HangHoas.Where(x=>x.TenHH.Contains(tenHH)).Take(8).ToList();
            if (tenHH == null)
            {
                lsv = db.HangHoas.Take(8).ToList();
            }
            ViewBag.ListHangHoa = lsv;
            ViewBag.HomePage = "active";
            ViewBag.ShopPage = "";
            return View();
        }
    }
}