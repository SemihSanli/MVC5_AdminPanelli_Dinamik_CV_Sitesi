using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
namespace MvcCV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_About.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.Tbl_SocialMedia.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Experience.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult egitimlerim()
        {
            var egitimler = db.Tbl_Education.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenek = db.Tbl_MySkills.ToList();
            return PartialView(yetenek);
        }
        public PartialViewResult Projelerim()
        {
            var proje = db.Tbl_Project.ToList();
            return PartialView(proje);
        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifika = db.Tbl_Certificate.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult İletisim(Tbl_Contact t)
        {
            db.Tbl_Contact.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}