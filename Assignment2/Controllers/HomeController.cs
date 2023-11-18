using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "All Cards";
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Card Details";
            return View();
        }

        public ActionResult UserDecks()
        {
            ViewBag.Title = "User Decks";
            return View();
        }

        public ActionResult DeckDisplay()
        {
            ViewBag.Title = "Deck DIsplay";
            return View();
        }
    }
}