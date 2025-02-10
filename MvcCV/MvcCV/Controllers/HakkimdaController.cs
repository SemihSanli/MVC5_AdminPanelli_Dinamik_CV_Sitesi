using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<Tbl_About> repo = new GenericRepository<Tbl_About>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
           
        }
        [HttpPost]
        public ActionResult Index(Tbl_About p)
        {
            var t = repo.Find(x=>x.ID== 1);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Address = p.Address;
            t.Phone = p.Phone;
            t.Mail = p.Mail;
            t.Description = p.Description;
            t.Images = p.Images;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}