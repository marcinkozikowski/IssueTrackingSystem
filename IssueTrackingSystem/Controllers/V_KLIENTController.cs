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
    public class V_KLIENTController : Controller
    {
        private Model1 db = new Model1();

        // GET: V_KLIENT
        public ActionResult Index()
        {
            return View(db.V_KLIENT.ToList());
        }

        // GET: V_KLIENT/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            V_KLIENT v_KLIENT = db.V_KLIENT.Find(id);
            if (v_KLIENT == null)
            {
                return HttpNotFound();
            }
            return View(v_KLIENT);
        }

        // GET: V_KLIENT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: V_KLIENT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDKLIENTA,LOGIN,KLIENT,ULICA,MIASTO,KOD_POCZTOWY,POCZTA,EMAIL,TELEFON,INNY")] V_KLIENT v_KLIENT)
        {
            if (ModelState.IsValid)
            {
                db.V_KLIENT.Add(v_KLIENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(v_KLIENT);
        }

        // GET: V_KLIENT/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            V_KLIENT v_KLIENT = db.V_KLIENT.Find(id);
            if (v_KLIENT == null)
            {
                return HttpNotFound();
            }
            return View(v_KLIENT);
        }

        // POST: V_KLIENT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDKLIENTA,LOGIN,KLIENT,ULICA,MIASTO,KOD_POCZTOWY,POCZTA,EMAIL,TELEFON,INNY")] V_KLIENT v_KLIENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(v_KLIENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(v_KLIENT);
        }

        // GET: V_KLIENT/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            V_KLIENT v_KLIENT = db.V_KLIENT.Find(id);
            if (v_KLIENT == null)
            {
                return HttpNotFound();
            }
            return View(v_KLIENT);
        }

        // POST: V_KLIENT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            V_KLIENT v_KLIENT = db.V_KLIENT.Find(id);
            db.V_KLIENT.Remove(v_KLIENT);
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
