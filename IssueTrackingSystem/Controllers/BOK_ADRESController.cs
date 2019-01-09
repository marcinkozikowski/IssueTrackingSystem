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
    public class BOK_ADRESController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_ADRES
        public ActionResult Index()
        {
            return View(db.BOK_ADRES.ToList());
        }

        // GET: BOK_ADRES/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ADRES bOK_ADRES = db.BOK_ADRES.Find(id);
            if (bOK_ADRES == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ADRES);
        }

        // GET: BOK_ADRES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BOK_ADRES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ADRES,ULICA,MIASTO,KOD_POCZTOWY,POCZTA")] BOK_ADRES bOK_ADRES)
        {
            if (ModelState.IsValid)
            {
                db.BOK_ADRES.Add(bOK_ADRES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bOK_ADRES);
        }

        // GET: BOK_ADRES/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ADRES bOK_ADRES = db.BOK_ADRES.Find(id);
            if (bOK_ADRES == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ADRES);
        }

        // POST: BOK_ADRES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ADRES,ULICA,MIASTO,KOD_POCZTOWY,POCZTA")] BOK_ADRES bOK_ADRES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_ADRES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bOK_ADRES);
        }

        // GET: BOK_ADRES/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ADRES bOK_ADRES = db.BOK_ADRES.Find(id);
            if (bOK_ADRES == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ADRES);
        }

        // POST: BOK_ADRES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_ADRES bOK_ADRES = db.BOK_ADRES.Find(id);
            db.BOK_ADRES.Remove(bOK_ADRES);
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
