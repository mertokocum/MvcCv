using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class ExperiencesController : Controller
    {
        // GET: Experiences
        ExperiencesRepository repo = new ExperiencesRepository();
        public ActionResult Index()
        {
            var experiences = repo.List();
            return View(experiences);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblExperiences p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            TblExperiences t = repo.Find(x=>x.ID==id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetExperience(int id)
        {
            TblExperiences t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult GetExperience(TblExperiences p)
        {
            TblExperiences t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.Sub_Title = p.Sub_Title;
            t.Date = p.Date;
            t.Details = p.Details;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult CancelEdit()
        {
            return RedirectToAction("Index");
        }

    }
}