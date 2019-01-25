using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IssueTrackingSystem.Models;

namespace IssueTrackingSystem.Views
{
    public class V_ZGLOSZENIEController : Controller
    {
        private Model1 db = new Model1();

        // GET: V_ZGLOSZENIE
        public ActionResult Index()
        {
            return View(db.V_ZGLOSZENIE.ToList());
        }

        // GET: V_ZGLOSZENIE/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            V_ZGLOSZENIE v_ZGLOSZENIE = db.V_ZGLOSZENIE.Find(id);
            if (v_ZGLOSZENIE == null)
            {
                return HttpNotFound();
            }
            return View(v_ZGLOSZENIE);
        }

        // GET: V_ZGLOSZENIE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: V_ZGLOSZENIE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,KLIENT,OPERATOR,STATUS,PRIORYTET,OPIS,DATA_UTWORZENIA,DATA_ZAKONCZENIA")] V_ZGLOSZENIE v_ZGLOSZENIE)
        {
            if (ModelState.IsValid)
            {
                db.V_ZGLOSZENIE.Add(v_ZGLOSZENIE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(v_ZGLOSZENIE);
        }

        // GET: V_ZGLOSZENIE/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            V_ZGLOSZENIE v_ZGLOSZENIE = db.V_ZGLOSZENIE.Find(id);
            if (v_ZGLOSZENIE == null)
            {
                return HttpNotFound();
            }
            return View(v_ZGLOSZENIE);
        }

        // POST: V_ZGLOSZENIE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,KLIENT,OPERATOR,STATUS,PRIORYTET,OPIS,DATA_UTWORZENIA,DATA_ZAKONCZENIA")] V_ZGLOSZENIE v_ZGLOSZENIE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(v_ZGLOSZENIE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(v_ZGLOSZENIE);
        }

        // GET: V_ZGLOSZENIE/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            V_ZGLOSZENIE v_ZGLOSZENIE = db.V_ZGLOSZENIE.Find(id);
            if (v_ZGLOSZENIE == null)
            {
                return HttpNotFound();
            }
            return View(v_ZGLOSZENIE);
        }

        // POST: V_ZGLOSZENIE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            V_ZGLOSZENIE v_ZGLOSZENIE = db.V_ZGLOSZENIE.Find(id);
            db.V_ZGLOSZENIE.Remove(v_ZGLOSZENIE);
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
