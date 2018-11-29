using Superheros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheros.Controllers
{
    public class HeroController : Controller
    {
        private ApplicationDbContext applicationDbContext;
        public HeroController()
        {
            applicationDbContext = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            applicationDbContext.Dispose();
        }



        // GET: Hero
        public ViewResult Index()
        {
            var myHero = applicationDbContext.Hero.ToList();

            return View(myHero);
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

            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.Message = "Edit page.";

            return View();
        }
    }
}