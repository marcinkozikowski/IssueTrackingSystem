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
    public class BOK_ZALACZNIKController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_ZALACZNIK
        public ActionResult Index()
        {
            var bOK_ZALACZNIK = db.BOK_ZALACZNIK.Include(b => b.BOK_ZGLOSZENIE);
            return View(bOK_ZALACZNIK.ToList());
        }

        // GET: BOK_ZALACZNIK/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ZALACZNIK bOK_ZALACZNIK = db.BOK_ZALACZNIK.Find(id);
            if (bOK_ZALACZNIK == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ZALACZNIK);
        }

        // GET: BOK_ZALACZNIK/Create
        public ActionResult Create()
        {
            ViewBag.ID_ZGLOSZENIA = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS");
            return View();
        }

        // POST: BOK_ZALACZNIK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ZALACZNIK,ID_ZGLOSZENIA,TRESC")] BOK_ZALACZNIK bOK_ZALACZNIK)
        {
            if (ModelState.IsValid)
            {
                db.BOK_ZALACZNIK.Add(bOK_ZALACZNIK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ZGLOSZENIA = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS", bOK_ZALACZNIK.ID_ZGLOSZENIA);
            return View(bOK_ZALACZNIK);
        }

        // GET: BOK_ZALACZNIK/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ZALACZNIK bOK_ZALACZNIK = db.BOK_ZALACZNIK.Find(id);
            if (bOK_ZALACZNIK == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ZGLOSZENIA = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS", bOK_ZALACZNIK.ID_ZGLOSZENIA);
            return View(bOK_ZALACZNIK);
        }

        // POST: BOK_ZALACZNIK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ZALACZNIK,ID_ZGLOSZENIA,TRESC")] BOK_ZALACZNIK bOK_ZALACZNIK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_ZALACZNIK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ZGLOSZENIA = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS", bOK_ZALACZNIK.ID_ZGLOSZENIA);
            return View(bOK_ZALACZNIK);
        }

        // GET: BOK_ZALACZNIK/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ZALACZNIK bOK_ZALACZNIK = db.BOK_ZALACZNIK.Find(id);
            if (bOK_ZALACZNIK == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ZALACZNIK);
        }

        // POST: BOK_ZALACZNIK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_ZALACZNIK bOK_ZALACZNIK = db.BOK_ZALACZNIK.Find(id);
            db.BOK_ZALACZNIK.Remove(bOK_ZALACZNIK);
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
