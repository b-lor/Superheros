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
        public ActionResult Delete(int id)
        {
            var hero = applicationDbContext.Hero.SingleOrDefault(i => i.Id == id);
            //Hero hero = applicationDbContext.Hero(id);
            if (hero == null)
            {
                return View("Superhero not found....");
            }
            else
            {
                applicationDbContext.Hero.Remove(hero);
                applicationDbContext.SaveChanges();
            }

            return View(hero);
        }

        public ViewResult Details()
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