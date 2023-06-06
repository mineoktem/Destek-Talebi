using DestekTaleplerim.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestekTaleplerim.MvcWebUI.Controllers
{
    
    public class HomeController : Controller

        
    {
        DataContext _context = new DataContext();


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult KullaniciSayfasi()
        {
            return View(_context.DestekTalepleri.ToList());
        }

        [Authorize(Users = "admin")]
        public ActionResult AdminSayfasi()
        {
            return View(_context.DestekTalepleri.ToList());
        }


        public ActionResult MesajDetayi(int id)
        {
            return View(_context.DestekTalepleri.Where(i=>i.Id==id).FirstOrDefault());
        }


    }
}