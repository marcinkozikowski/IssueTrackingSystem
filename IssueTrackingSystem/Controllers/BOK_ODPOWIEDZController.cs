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
    public class BOK_ODPOWIEDZController : Controller
    {
        private Model1 db = new Model1();

        // GET: BOK_ODPOWIEDZ
        public ActionResult Index()
        {
            var bOK_ODPOWIEDZ = db.BOK_ODPOWIEDZ.Include(b => b.BOK_OPERATOR).Include(b => b.BOK_ZGLOSZENIE);
            return View(bOK_ODPOWIEDZ.ToList());
        }

        // GET: BOK_ODPOWIEDZ/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ODPOWIEDZ bOK_ODPOWIEDZ = db.BOK_ODPOWIEDZ.Find(id);
            if (bOK_ODPOWIEDZ == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ODPOWIEDZ);
        }

        // GET: BOK_ODPOWIEDZ/Create
        public ActionResult Create()
        {
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA");
            ViewBag.ID_ZGLOSZENIE = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS");
            return View();
        }

        // POST: BOK_ODPOWIEDZ/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ODPOWIEDZI,ID_ZGLOSZENIE,ID_OPERATOR,OPIS,DATA_ODPOWIEDZI")] BOK_ODPOWIEDZ bOK_ODPOWIEDZ)
        {
            if (ModelState.IsValid)
            {
                db.BOK_ODPOWIEDZ.Add(bOK_ODPOWIEDZ);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_ODPOWIEDZ.ID_OPERATOR);
            ViewBag.ID_ZGLOSZENIE = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS", bOK_ODPOWIEDZ.ID_ZGLOSZENIE);
            return View(bOK_ODPOWIEDZ);
        }

        // GET: BOK_ODPOWIEDZ/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ODPOWIEDZ bOK_ODPOWIEDZ = db.BOK_ODPOWIEDZ.Find(id);
            if (bOK_ODPOWIEDZ == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_ODPOWIEDZ.ID_OPERATOR);
            ViewBag.ID_ZGLOSZENIE = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS", bOK_ODPOWIEDZ.ID_ZGLOSZENIE);
            return View(bOK_ODPOWIEDZ);
        }

        // POST: BOK_ODPOWIEDZ/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ODPOWIEDZI,ID_ZGLOSZENIE,ID_OPERATOR,OPIS,DATA_ODPOWIEDZI")] BOK_ODPOWIEDZ bOK_ODPOWIEDZ)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOK_ODPOWIEDZ).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_OPERATOR = new SelectList(db.BOK_OPERATOR, "ID_OPERATOR", "NAZWA", bOK_ODPOWIEDZ.ID_OPERATOR);
            ViewBag.ID_ZGLOSZENIE = new SelectList(db.BOK_ZGLOSZENIE, "ID_ZGLOSZENIE", "OPIS", bOK_ODPOWIEDZ.ID_ZGLOSZENIE);
            return View(bOK_ODPOWIEDZ);
        }

        // GET: BOK_ODPOWIEDZ/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOK_ODPOWIEDZ bOK_ODPOWIEDZ = db.BOK_ODPOWIEDZ.Find(id);
            if (bOK_ODPOWIEDZ == null)
            {
                return HttpNotFound();
            }
            return View(bOK_ODPOWIEDZ);
        }

        // POST: BOK_ODPOWIEDZ/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOK_ODPOWIEDZ bOK_ODPOWIEDZ = db.BOK_ODPOWIEDZ.Find(id);
            db.BOK_ODPOWIEDZ.Remove(bOK_ODPOWIEDZ);
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
