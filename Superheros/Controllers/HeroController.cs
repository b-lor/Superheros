using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheros.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            ViewBag.Message = "Index page.";
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Create page.";
            return View();
        }
        public ActionResult Delete()
        {
            ViewBag.Message = "Delete page.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Details page.";

            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.Message = "Edit page.";

            return View();
        }
    }
}