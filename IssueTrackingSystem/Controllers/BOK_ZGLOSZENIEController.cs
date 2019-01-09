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
    public class BOK_ZGLOSZENIEController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_ZGLOSZENIE
        public ActionResult Index()
        {
            var bOK_ZGLOSZENIE = db.BOK_ZGLOSZENIE.Include(b => b.BOK_KLIENT).Include(b => b.BOK_OPERATOR).Include(b => b.BOK_PRIORYTET).Include(b => b.BOK_STATUS);
            return View(bOK_ZGLOSZENIE.ToList());
        }

        // GET: BOK_ZGLOSZENIE/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ZGLOSZENIE bOK_ZGLOSZENIE = db.BOK_ZGLOSZENIE.Find(id);
            if (bOK_ZGLOSZENIE == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ZGLOSZENIE);
        }

        // GET: BOK_ZGLOSZENIE/Create
        public ActionResult Create()
        {
            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA");
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA");
            ViewBag.ID_PRIORYTET = new SelectList(db.BOK_PRIORYTET, "ID_PRIORYTET", "OPIS");
            ViewBag.ID_STATUS = new SelectList(db.BOK_STATUS, "ID_STATUS", "OPIS");
            return View();
        }

        // POST: BOK_ZGLOSZENIE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ZGLOSZENIE,ID_KLIENTA,ID_OPERATOR,ID_STATUS,ID_PRIORYTET,OPIS,DATA_UTWORZENIA,DATA_ZAKONCZENIA")] BOK_ZGLOSZENIE bOK_ZGLOSZENIE)
        {
            if (ModelState.IsValid)
            {
                db.BOK_ZGLOSZENIE.Add(bOK_ZGLOSZENIE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA", bOK_ZGLOSZENIE.ID_KLIENTA);
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_ZGLOSZENIE.ID_OPERATOR);
            ViewBag.ID_PRIORYTET = new SelectList(db.BOK_PRIORYTET, "ID_PRIORYTET", "OPIS", bOK_ZGLOSZENIE.ID_PRIORYTET);
            ViewBag.ID_STATUS = new SelectList(db.BOK_STATUS, "ID_STATUS", "OPIS", bOK_ZGLOSZENIE.ID_STATUS);
            return View(bOK_ZGLOSZENIE);
        }

        // GET: BOK_ZGLOSZENIE/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ZGLOSZENIE bOK_ZGLOSZENIE = db.BOK_ZGLOSZENIE.Find(id);
            if (bOK_ZGLOSZENIE == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA", bOK_ZGLOSZENIE.ID_KLIENTA);
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_ZGLOSZENIE.ID_OPERATOR);
            ViewBag.ID_PRIORYTET = new SelectList(db.BOK_PRIORYTET, "ID_PRIORYTET", "OPIS", bOK_ZGLOSZENIE.ID_PRIORYTET);
            ViewBag.ID_STATUS = new SelectList(db.BOK_STATUS, "ID_STATUS", "OPIS", bOK_ZGLOSZENIE.ID_STATUS);
            return View(bOK_ZGLOSZENIE);
        }

        // POST: BOK_ZGLOSZENIE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ZGLOSZENIE,ID_KLIENTA,ID_OPERATOR,ID_STATUS,ID_PRIORYTET,OPIS,DATA_UTWORZENIA,DATA_ZAKONCZENIA")] BOK_ZGLOSZENIE bOK_ZGLOSZENIE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_ZGLOSZENIE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_KLIENTA = new SelectList(db.BOK_KLIENT, "ID_KLIENTA", "NAZWA", bOK_ZGLOSZENIE.ID_KLIENTA);
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_ZGLOSZENIE.ID_OPERATOR);
            ViewBag.ID_PRIORYTET = new SelectList(db.BOK_PRIORYTET, "ID_PRIORYTET", "OPIS", bOK_ZGLOSZENIE.ID_PRIORYTET);
            ViewBag.ID_STATUS = new SelectList(db.BOK_STATUS, "ID_STATUS", "OPIS", bOK_ZGLOSZENIE.ID_STATUS);
            return View(bOK_ZGLOSZENIE);
        }

        // GET: BOK_ZGLOSZENIE/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ZGLOSZENIE bOK_ZGLOSZENIE = db.BOK_ZGLOSZENIE.Find(id);
            if (bOK_ZGLOSZENIE == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ZGLOSZENIE);
        }

        // POST: BOK_ZGLOSZENIE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_ZGLOSZENIE bOK_ZGLOSZENIE = db.BOK_ZGLOSZENIE.Find(id);
            db.BOK_ZGLOSZENIE.Remove(bOK_ZGLOSZENIE);
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
