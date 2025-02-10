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
    }
}