using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username,string password)
        {
            Kullanıcı user = new Kullanıcı();
            user.Username = username;
            user.Password = password;
            return View("Giris",user);
        }
       

    }
}