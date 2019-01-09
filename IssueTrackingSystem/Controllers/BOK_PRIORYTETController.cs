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
    public class BOK_PRIORYTETController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_PRIORYTET
        public ActionResult Index()
        {
            return View(db.BOK_PRIORYTET.ToList());
        }

        // GET: BOK_PRIORYTET/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_PRIORYTET bOK_PRIORYTET = db.BOK_PRIORYTET.Find(id);
            if (bOK_PRIORYTET == null)
            {
                return HttpNotFound();
            }
            return View(bOK_PRIORYTET);
        }

        // GET: BOK_PRIORYTET/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BOK_PRIORYTET/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PRIORYTET,OPIS")] BOK_PRIORYTET bOK_PRIORYTET)
        {
            if (ModelState.IsValid)
            {
                db.BOK_PRIORYTET.Add(bOK_PRIORYTET);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bOK_PRIORYTET);
        }

        // GET: BOK_PRIORYTET/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_PRIORYTET bOK_PRIORYTET = db.BOK_PRIORYTET.Find(id);
            if (bOK_PRIORYTET == null)
            {
                return HttpNotFound();
            }
            return View(bOK_PRIORYTET);
        }

        // POST: BOK_PRIORYTET/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PRIORYTET,OPIS")] BOK_PRIORYTET bOK_PRIORYTET)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_PRIORYTET).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bOK_PRIORYTET);
        }

        // GET: BOK_PRIORYTET/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_PRIORYTET bOK_PRIORYTET = db.BOK_PRIORYTET.Find(id);
            if (bOK_PRIORYTET == null)
            {
                return HttpNotFound();
            }
            return View(bOK_PRIORYTET);
        }

        // POST: BOK_PRIORYTET/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_PRIORYTET bOK_PRIORYTET = db.BOK_PRIORYTET.Find(id);
            db.BOK_PRIORYTET.Remove(bOK_PRIORYTET);
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
