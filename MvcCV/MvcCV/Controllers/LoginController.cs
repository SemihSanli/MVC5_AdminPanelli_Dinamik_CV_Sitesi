using MvcCV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCV.Controllers
{
    public class LoginController : Controller
    {
       
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin p)
        {
            DbCVEntities db = new DbCVEntities();
            var User = db.Tbl_Admin.FirstOrDefault(x=>x.Username == p.Username && x.Password==p.Password ) ;
            if(User != null)
            {
                FormsAuthentication.SetAuthCookie(User.Username, false);
                Session["Username"]=User.Username.ToString();
                return RedirectToAction("Index","Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}