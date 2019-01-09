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
    public class BOK_OPERATORController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_OPERATOR
        public ActionResult Index()
        {
            return View(db.BOK_OPERATOR.ToList());
        }

        // GET: BOK_OPERATOR/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_OPERATOR bOK_OPERATOR = db.BOK_OPERATOR.Find(id);
            if (bOK_OPERATOR == null)
            {
                return HttpNotFound();
            }
            return View(bOK_OPERATOR);
        }

        // GET: BOK_OPERATOR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BOK_OPERATOR/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_OPERATOR,NAZWA")] BOK_OPERATOR bOK_OPERATOR)
        {
            if (ModelState.IsValid)
            {
                db.BOK_OPERATOR.Add(bOK_OPERATOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bOK_OPERATOR);
        }

        // GET: BOK_OPERATOR/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_OPERATOR bOK_OPERATOR = db.BOK_OPERATOR.Find(id);
            if (bOK_OPERATOR == null)
            {
                return HttpNotFound();
            }
            return View(bOK_OPERATOR);
        }

        // POST: BOK_OPERATOR/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_OPERATOR,NAZWA")] BOK_OPERATOR bOK_OPERATOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_OPERATOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bOK_OPERATOR);
        }

        // GET: BOK_OPERATOR/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_OPERATOR bOK_OPERATOR = db.BOK_OPERATOR.Find(id);
            if (bOK_OPERATOR == null)
            {
                return HttpNotFound();
            }
            return View(bOK_OPERATOR);
        }

        // POST: BOK_OPERATOR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_OPERATOR bOK_OPERATOR = db.BOK_OPERATOR.Find(id);
            db.BOK_OPERATOR.Remove(bOK_OPERATOR);
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
