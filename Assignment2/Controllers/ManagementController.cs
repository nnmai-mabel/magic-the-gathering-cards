using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult CreateDeck()
        {
            ViewBag.Title = "Create Decks";
            return View();
        }
    }
}