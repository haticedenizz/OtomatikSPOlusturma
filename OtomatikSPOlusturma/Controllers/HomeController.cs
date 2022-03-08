using OtomatikSPOlusturma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomatikSPOlusturma.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            db.Kitaplar.ToList();

            Kitap k = new Kitap() { KitapAd = "Sefiller", Aciklama = "Açıklama", YatinTarihi = DateTime.Now };
            db.Kitaplar.Add(k);
            db.SaveChanges();


            return View();
        }
    }
}