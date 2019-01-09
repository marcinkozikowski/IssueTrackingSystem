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
    public class BOK_UZYTKOWNIKController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_UZYTKOWNIK
        public ActionResult Index()
        {
            var bOK_UZYTKOWNIK = db.BOK_UZYTKOWNIK.Include(b => b.BOK_KLIENT).Include(b => b.BOK_OPERATOR);
            return View(bOK_UZYTKOWNIK.ToList());
        }

        // GET: BOK_UZYTKOWNIK/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_UZYTKOWNIK bOK_UZYTKOWNIK = db.BOK_UZYTKOWNIK.Find(id);
            if (bOK_UZYTKOWNIK == null)
            {
                return HttpNotFound();
            }
            return View(bOK_UZYTKOWNIK);
        }

        // GET: BOK_UZYTKOWNIK/Create
        public ActionResult Create()
        {
            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA");
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA");
            return View();
        }

        // POST: BOK_UZYTKOWNIK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_UZYTKOWNIK,ID_KLIENTA,ID_OPERATOR,LOGIN,PASSWORD_HASH,AKTYWNY")] BOK_UZYTKOWNIK bOK_UZYTKOWNIK)
        {
            if (ModelState.IsValid)
            {
                db.BOK_UZYTKOWNIK.Add(bOK_UZYTKOWNIK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA", bOK_UZYTKOWNIK.ID_KLIENTA);
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_UZYTKOWNIK.ID_OPERATOR);
            return View(bOK_UZYTKOWNIK);
        }

        // GET: BOK_UZYTKOWNIK/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_UZYTKOWNIK bOK_UZYTKOWNIK = db.BOK_UZYTKOWNIK.Find(id);
            if (bOK_UZYTKOWNIK == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA", bOK_UZYTKOWNIK.ID_KLIENTA);
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_UZYTKOWNIK.ID_OPERATOR);
            return View(bOK_UZYTKOWNIK);
        }

        // POST: BOK_UZYTKOWNIK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_UZYTKOWNIK,ID_KLIENTA,ID_OPERATOR,LOGIN,PASSWORD_HASH,AKTYWNY")] BOK_UZYTKOWNIK bOK_UZYTKOWNIK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_UZYTKOWNIK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA", bOK_UZYTKOWNIK.ID_KLIENTA);
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_UZYTKOWNIK.ID_OPERATOR);
            return View(bOK_UZYTKOWNIK);
        }

        // GET: BOK_UZYTKOWNIK/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_UZYTKOWNIK bOK_UZYTKOWNIK = db.BOK_UZYTKOWNIK.Find(id);
            if (bOK_UZYTKOWNIK == null)
            {
                return HttpNotFound();
            }
            return View(bOK_UZYTKOWNIK);
        }

        // POST: BOK_UZYTKOWNIK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_UZYTKOWNIK bOK_UZYTKOWNIK = db.BOK_UZYTKOWNIK.Find(id);
            db.BOK_UZYTKOWNIK.Remove(bOK_UZYTKOWNIK);
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
