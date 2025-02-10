using MvcCV.Models.Entity;
using MvcCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCV.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<Tbl_Contact> repo = new GenericRepository<Tbl_Contact>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            
            return View();
        }
    }
}