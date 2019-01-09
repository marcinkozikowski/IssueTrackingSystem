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
    public class BOK_DANE_KONTAKTOWEController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_DANE_KONTAKTOWE
        public ActionResult Index()
        {
            return View(db.BOK_DANE_KONTAKTOWE.ToList());
        }

        // GET: BOK_DANE_KONTAKTOWE/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_DANE_KONTAKTOWE bOK_DANE_KONTAKTOWE = db.BOK_DANE_KONTAKTOWE.Find(id);
            if (bOK_DANE_KONTAKTOWE == null)
            {
                return HttpNotFound();
            }
            return View(bOK_DANE_KONTAKTOWE);
        }

        // GET: BOK_DANE_KONTAKTOWE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BOK_DANE_KONTAKTOWE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_DANE_KONTAKTOWE,EMAIL,TELEFON,INNY")] BOK_DANE_KONTAKTOWE bOK_DANE_KONTAKTOWE)
        {
            if (ModelState.IsValid)
            {
                db.BOK_DANE_KONTAKTOWE.Add(bOK_DANE_KONTAKTOWE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bOK_DANE_KONTAKTOWE);
        }

        // GET: BOK_DANE_KONTAKTOWE/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_DANE_KONTAKTOWE bOK_DANE_KONTAKTOWE = db.BOK_DANE_KONTAKTOWE.Find(id);
            if (bOK_DANE_KONTAKTOWE == null)
            {
                return HttpNotFound();
            }
            return View(bOK_DANE_KONTAKTOWE);
        }

        // POST: BOK_DANE_KONTAKTOWE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_DANE_KONTAKTOWE,EMAIL,TELEFON,INNY")] BOK_DANE_KONTAKTOWE bOK_DANE_KONTAKTOWE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_DANE_KONTAKTOWE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bOK_DANE_KONTAKTOWE);
        }

        // GET: BOK_DANE_KONTAKTOWE/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_DANE_KONTAKTOWE bOK_DANE_KONTAKTOWE = db.BOK_DANE_KONTAKTOWE.Find(id);
            if (bOK_DANE_KONTAKTOWE == null)
            {
                return HttpNotFound();
            }
            return View(bOK_DANE_KONTAKTOWE);
        }

        // POST: BOK_DANE_KONTAKTOWE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_DANE_KONTAKTOWE bOK_DANE_KONTAKTOWE = db.BOK_DANE_KONTAKTOWE.Find(id);
            db.BOK_DANE_KONTAKTOWE.Remove(bOK_DANE_KONTAKTOWE);
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
