using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;
namespace MvcCV.Controllers
{
    public class SocialMediaController : Controller
    {
       
        // GET: SocialMedia
        GenericRepository<Tbl_SocialMedia> repo=new GenericRepository<Tbl_SocialMedia>();
        public ActionResult Index()
        {
            var veriler = repo.List();
            return View(veriler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();   
        }
        [HttpPost]
        public ActionResult Ekle(Tbl_SocialMedia p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public  ActionResult SayfaGetir(int id)
        {
            var hesap=repo.Find(x=>x.ID==id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(Tbl_SocialMedia p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.nameS = p.nameS;
            hesap.Durum = true;
            hesap.Link = p.Link;
            hesap.Icon = p.Icon;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var hesap=repo.Find(x=>x.ID== id);
            hesap.Durum = false;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
    }
}