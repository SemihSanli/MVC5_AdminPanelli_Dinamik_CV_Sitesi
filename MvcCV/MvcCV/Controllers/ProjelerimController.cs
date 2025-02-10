using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
   
    public class ProjelerimController : Controller
    {
       
        // GET: Projelerim
        ProjeRepository repo = new ProjeRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult ProjeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProjeEkle(Tbl_Project p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
           
        }
        public ActionResult ProjeSil(int id)
        {
           Tbl_Project t = repo.Find(x => x.ID == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ProjeGetir(int id)
        {
            Tbl_Project t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult ProjeGetir(Tbl_Project p)
        {
            Tbl_Project t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.SecondTitle = p.SecondTitle;
            t.Description = p.Description;
           t.Link = p.Link;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}