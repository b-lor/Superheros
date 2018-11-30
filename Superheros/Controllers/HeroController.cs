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
        private ApplicationDbContext db;

        public HeroController()
        {
            db = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }


        // GET: Hero
     
        public ViewResult Index()
        {
            var myHero = db.Hero.ToList();

            return View(myHero);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            Add(hero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public void Add(Hero hero)
        {
            db.Hero.Add(hero);
        }
        

        public ActionResult Delete(int id)
        {
            var hero = db.Hero.Where(d => d.Id == id).First();
            return View(hero);
        }

        //ie-https://stackoverflow.com/questions/11767911/mvc-httppost-httpget-for-action

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(Hero hero)
        {
            Hero removeHero = db.Hero.Where(h => h.Id == hero.Id).First();
            db.Hero.Remove(removeHero);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


        public ViewResult Details(int id)
        {
            var hero = db.Hero.SingleOrDefault(i => i.Id == id);
            if (hero == null)
                return View("Index");
            else
                return View(hero);
        }
        public ActionResult Edit(int id)
        {
            var editHero = db.Hero.Where(e => e.Id == id).First();
            return View(editHero);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Hero hero)
        {
            Hero editHero = db.Hero.Where(e => e.Id == hero.Id).First();
            editHero.Name = hero.Name;
            editHero.AlterEgo = hero.AlterEgo;
            editHero.AbilityOne = hero.AbilityOne;
            editHero.AbilityTwo = hero.AbilityTwo;
            editHero.Catchphrase = hero.Catchphrase;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}