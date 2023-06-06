using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DestekTaleplerim.MvcWebUI.Entity;

namespace DestekTaleplerim.MvcWebUI.Controllers
{
    [Authorize (Users = "admin")]
    public class AdminDestekTalebiController : Controller
    {
        private DataContext db = new DataContext();

        // GET: AdminDestekTalebi
        public ActionResult Index()
        {
            var destekTalepleri = db.DestekTalepleri.Include(d => d.Mesajlar);
            return View(destekTalepleri.ToList());
        }

        // GET: AdminDestekTalebi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DestekTalebi destekTalebi = db.DestekTalepleri.Find(id);
            if (destekTalebi == null)
            {
                return HttpNotFound();
            }
            return View(destekTalebi);
        }

        // GET: AdminDestekTalebi/Create
        public ActionResult Create()
        {
            ViewBag.MesajlarId = new SelectList(db.Mesajlars, "Id", "Icerik");
            return View();
        }

        // POST: AdminDestekTalebi/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TalepNo,Tarih,Konu,Durum,MesajlarId,IslemYapan,Oncelik")] DestekTalebi destekTalebi)
        {
            if (ModelState.IsValid)
            {
                db.DestekTalepleri.Add(destekTalebi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MesajlarId = new SelectList(db.Mesajlars, "Id", "Icerik", destekTalebi.MesajlarId);
            return View(destekTalebi);
        }

        // GET: AdminDestekTalebi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DestekTalebi destekTalebi = db.DestekTalepleri.Find(id);
            if (destekTalebi == null)
            {
                return HttpNotFound();
            }
            ViewBag.MesajlarId = new SelectList(db.Mesajlars, "Id", "Icerik", destekTalebi.MesajlarId);
            return View(destekTalebi);
        }

        // POST: AdminDestekTalebi/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TalepNo,Tarih,Konu,Durum,MesajlarId,IslemYapan,Oncelik")] DestekTalebi destekTalebi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destekTalebi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MesajlarId = new SelectList(db.Mesajlars, "Id", "Icerik", destekTalebi.MesajlarId);
            return View(destekTalebi);
        }

        // GET: AdminDestekTalebi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DestekTalebi destekTalebi = db.DestekTalepleri.Find(id);
            if (destekTalebi == null)
            {
                return HttpNotFound();
            }
            return View(destekTalebi);
        }

        // POST: AdminDestekTalebi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DestekTalebi destekTalebi = db.DestekTalepleri.Find(id);
            db.DestekTalepleri.Remove(destekTalebi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
