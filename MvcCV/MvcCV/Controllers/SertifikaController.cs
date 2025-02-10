﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entity;
using MvcCV.Repositories;
namespace MvcCV.Controllers
{
    public class SertifikaController : Controller
    {
       
        // GET: Sertifika
        GenericRepository<Tbl_Certificate> repo=new GenericRepository<Tbl_Certificate>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(Tbl_Certificate t)
        {
            var sertifika = repo.Find(x => x.ID == t.ID);
            sertifika.Description = t.Description;
            sertifika.Date = t.Date;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(Tbl_Certificate p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sertifika =repo.Find(x=>x.ID== id);
           
           
            repo.TRemove(sertifika);
            return RedirectToAction("Index");
        }
    }
}