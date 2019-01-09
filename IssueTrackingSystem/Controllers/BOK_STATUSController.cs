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
    public class BOK_STATUSController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_STATUS
        public ActionResult Index()
        {
            return View(db.BOK_STATUS.ToList());
        }

        // GET: BOK_STATUS/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_STATUS bOK_STATUS = db.BOK_STATUS.Find(id);
            if (bOK_STATUS == null)
            {
                return HttpNotFound();
            }
            return View(bOK_STATUS);
        }

        // GET: BOK_STATUS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BOK_STATUS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_STATUS,OPIS")] BOK_STATUS bOK_STATUS)
        {
            if (ModelState.IsValid)
            {
                db.BOK_STATUS.Add(bOK_STATUS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bOK_STATUS);
        }

        // GET: BOK_STATUS/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_STATUS bOK_STATUS = db.BOK_STATUS.Find(id);
            if (bOK_STATUS == null)
            {
                return HttpNotFound();
            }
            return View(bOK_STATUS);
        }

        // POST: BOK_STATUS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_STATUS,OPIS")] BOK_STATUS bOK_STATUS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_STATUS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bOK_STATUS);
        }

        // GET: BOK_STATUS/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_STATUS bOK_STATUS = db.BOK_STATUS.Find(id);
            if (bOK_STATUS == null)
            {
                return HttpNotFound();
            }
            return View(bOK_STATUS);
        }

        // POST: BOK_STATUS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_STATUS bOK_STATUS = db.BOK_STATUS.Find(id);
            db.BOK_STATUS.Remove(bOK_STATUS);
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
