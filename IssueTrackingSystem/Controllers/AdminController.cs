using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IssueTrackingSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adres()
        {
            return RedirectToAction("Index", "BOK_ADRES");
        }

        public ActionResult Kontakty()
        {
            return RedirectToAction("Index", "BOK_DANE_KONTAKTOWE");
        }

        public ActionResult Klienci()
        {
            return RedirectToAction("Index", "BOK_KLIENT");
        }
        public ActionResult Odpowiedz()
        {
            return RedirectToAction("Index", "BOK_ODPOWIEDZ");
        }

        public ActionResult Operator()
        {
            return RedirectToAction("Index", "BOK_OPERATOR");
        }
        public ActionResult Priorytet()
        {
            return RedirectToAction("Index", "BOK_PRIORYTET");
        }

        public ActionResult Status()
        {
            return RedirectToAction("Index", "BOK_STATUS");
        }
        public ActionResult Uzytkownik()
        {
            return RedirectToAction("Index", "BOK_UZYTKOWNIK");
        }

        public ActionResult Zalacznik()
        {
            return RedirectToAction("Index", "BOK_ZALACZNIK");
        }
        public ActionResult Zgloszenie()
        {
            return RedirectToAction("Index", "BOK_ZGLOSZENIE");
        }

    }
}