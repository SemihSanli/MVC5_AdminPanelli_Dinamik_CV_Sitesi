using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;
namespace MvcCV.Controllers
{
   
    public class YetenekController : Controller
    {
        // GET: Yetenek
        
        GenericRepository<Tbl_MySkills> repo=new GenericRepository<Tbl_MySkills>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Tbl_MySkills p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            repo.TRemove(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDuzenle(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(Tbl_MySkills t)
        {
            var yetenek = repo.Find(x => x.ID == t.ID);
            yetenek.Skill = t.Skill;
            yetenek.Ratio = t.Ratio;
            repo.TUpdate(yetenek);
            return RedirectToAction("Index");
        }
    }
}