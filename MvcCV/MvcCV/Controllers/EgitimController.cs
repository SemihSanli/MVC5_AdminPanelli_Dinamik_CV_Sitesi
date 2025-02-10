using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
   
    public class EgitimController : Controller
    {
        // GET: Egitim
        GenericRepository<Tbl_Education> repo = new GenericRepository<Tbl_Education>();
       
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(Tbl_Education p)
        {
            if (!ModelState.IsValid) 
            {
                return View("EgitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult  EgitimSil(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            repo.TRemove(egitim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim=repo.Find(x => x.ID == id); ;
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EgitimDuzenle(Tbl_Education t)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            var egitim = repo.Find(x => x.ID == t.ID); ;
            egitim.Title = t.Title; 
            egitim.SecondTitle = t.SecondTitle;
            egitim.SecondTitle2 = t.SecondTitle2;
            egitim.Date = t.Date;
            egitim.NoteSum = t.NoteSum;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }
    }
}