using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DONGDUONGPLA.Models;
using PagedList;



namespace DONGDUONGPLA.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop

        public ActionResult Index(int? page, int? pagesize,string TeHH)
        {
            Hshop2023Entities1 db = new Hshop2023Entities1();
            List<Loai> lsvLoai = db.Loais.ToList();
            List<HangHoa> lsvHangHoa = db.HangHoas.ToList();
            if (TeHH != null)
            {
                lsvHangHoa = db.HangHoas.Where(x => x.TenHH.Contains(TeHH)).ToList();
            }

            if (page == null)
            {
                page = 1;
            }
            if (pagesize == null)
            {
                pagesize = 9;
            }
            ViewBag.Loai = lsvLoai;
            ViewBag.HomePage = "";
            ViewBag.ShopPage = "active";
            ViewBag.AboutPage = "";
            ViewBag.ContactPage = "";
            return View(lsvHangHoa.ToPagedList((int)page,(int)pagesize));
        }

        public ActionResult ShopDetail(int MAHH)
        {
            Hshop2023Entities1 db = new Hshop2023Entities1();
            HangHoa hh = db.HangHoas.FirstOrDefault(x => x.MaHH == MAHH);
            ViewBag.hanghoa = hh;
            return View();
        }
    }
}