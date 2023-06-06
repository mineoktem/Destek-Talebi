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

    [Authorize]
    public class MesajlarController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Mesajlars
        public ActionResult Index()
        {
            var mesajlars = db.Mesajlars.Include(m => m.DestekTalebi);
            return View(mesajlars.ToList());
        }

        // GET: Mesajlars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesajlar mesajlar = db.Mesajlars.Find(id);
            if (mesajlar == null)
            {
                return HttpNotFound();
            }
            return View(mesajlar);
        }

        // GET: Mesajlars/Create
        public ActionResult Create()
        {
            ViewBag.DestekTalebiId = new SelectList(db.DestekTalepleri, "Id", "Tarih");
            return View();
        }

        // POST: Mesajlars/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipi,Icerik,DestekTalebiId")] Mesajlar mesajlar)
        {
            if (ModelState.IsValid)
            {
                db.Mesajlars.Add(mesajlar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DestekTalebiId = new SelectList(db.DestekTalepleri, "Id", "Tarih", mesajlar.DestekTalebiId);
            return View(mesajlar);
        }

        // GET: Mesajlars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesajlar mesajlar = db.Mesajlars.Find(id);
            if (mesajlar == null)
            {
                return HttpNotFound();
            }
            ViewBag.DestekTalebiId = new SelectList(db.DestekTalepleri, "Id", "Tarih", mesajlar.DestekTalebiId);
            return View(mesajlar);
        }

        // POST: Mesajlars/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipi,Icerik,DestekTalebiId")] Mesajlar mesajlar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mesajlar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DestekTalebiId = new SelectList(db.DestekTalepleri, "Id", "Tarih", mesajlar.DestekTalebiId);
            return View(mesajlar);
        }

        // GET: Mesajlars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesajlar mesajlar = db.Mesajlars.Find(id);
            if (mesajlar == null)
            {
                return HttpNotFound();
            }
            return View(mesajlar);
        }

        // POST: Mesajlars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mesajlar mesajlar = db.Mesajlars.Find(id);
            db.Mesajlars.Remove(mesajlar);
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
