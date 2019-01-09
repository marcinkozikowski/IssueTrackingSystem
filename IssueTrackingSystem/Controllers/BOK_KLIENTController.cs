using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IssueTrackingSystem.Models;

namespace IssueTrackingSystem.Controllers
{
    public class BOK_KLIENTController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_KLIENT
        public ActionResult Index()
        {
            var bOK_KLIENT = db.BOK_KLIENT.Include(b => b.BOK_ADRES).Include(b => b.BOK_DANE_KONTAKTOWE);
            return View(bOK_KLIENT.ToList());
        }

        // GET: BOK_KLIENT/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_KLIENT bOK_KLIENT = db.BOK_KLIENT.Find(id);
            if (bOK_KLIENT == null)
            {
                return HttpNotFound();
            }
            return View(bOK_KLIENT);
        }

        // GET: BOK_KLIENT/Create
        public ActionResult Create()
        {
            ViewBag.ID_ADRES = new SelectList(db.BOK_ADRES, "ID_ADRES", "ULICA");
            ViewBag.ID_DANE_KONTAKTOWE = new SelectList(db.BOK_DANE_KONTAKTOWE, "ID_DANE_KONTAKTOWE", "EMAIL");
            return View();
        }

        // POST: BOK_KLIENT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_KLIENTA,ID_DANE_KONTAKTOWE,ID_ADRES,NAZWA")] BOK_KLIENT bOK_KLIENT)
        {
            if (ModelState.IsValid)
            {
                db.BOK_KLIENT.Add(bOK_KLIENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ADRES = new SelectList(db.BOK_ADRES, "ID_ADRES", "ULICA", bOK_KLIENT.ID_ADRES);
            ViewBag.ID_DANE_KONTAKTOWE = new SelectList(db.BOK_DANE_KONTAKTOWE, "ID_DANE_KONTAKTOWE", "EMAIL", bOK_KLIENT.ID_DANE_KONTAKTOWE);
            return View(bOK_KLIENT);
        }

        // GET: BOK_KLIENT/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_KLIENT bOK_KLIENT = db.BOK_KLIENT.Find(id);
            if (bOK_KLIENT == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ADRES = new SelectList(db.BOK_ADRES, "ID_ADRES", "ULICA", bOK_KLIENT.ID_ADRES);
            ViewBag.ID_DANE_KONTAKTOWE = new SelectList(db.BOK_DANE_KONTAKTOWE, "ID_DANE_KONTAKTOWE", "EMAIL", bOK_KLIENT.ID_DANE_KONTAKTOWE);
            return View(bOK_KLIENT);
        }

        // POST: BOK_KLIENT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_KLIENTA,ID_DANE_KONTAKTOWE,ID_ADRES,NAZWA")] BOK_KLIENT bOK_KLIENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_KLIENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ADRES = new SelectList(db.BOK_ADRES, "ID_ADRES", "ULICA", bOK_KLIENT.ID_ADRES);
            ViewBag.ID_DANE_KONTAKTOWE = new SelectList(db.BOK_DANE_KONTAKTOWE, "ID_DANE_KONTAKTOWE", "EMAIL", bOK_KLIENT.ID_DANE_KONTAKTOWE);
            return View(bOK_KLIENT);
        }

        // GET: BOK_KLIENT/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_KLIENT bOK_KLIENT = db.BOK_KLIENT.Find(id);
            if (bOK_KLIENT == null)
            {
                return HttpNotFound();
            }
            return View(bOK_KLIENT);
        }

        // POST: BOK_KLIENT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_KLIENT bOK_KLIENT = db.BOK_KLIENT.Find(id);
            db.BOK_KLIENT.Remove(bOK_KLIENT);
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
