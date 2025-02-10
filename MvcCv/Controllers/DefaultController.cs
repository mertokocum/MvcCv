using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var values = db.TblAboutme.ToList();
            return View(values);
        }
        public PartialViewResult Experience()
        {
            var experiences = db.TblExperiences.ToList();
            return PartialView(experiences);
        }
        public PartialViewResult Education()
        {
            var educations = db.TblEducation.ToList();
            return PartialView(educations);
        }
        public PartialViewResult Skills()
        {
            var skills = db.TblSkills.ToList();
            return PartialView(skills);
        }
        public PartialViewResult Hobbies()
        {
            var hobbies = db.TblHobbies.ToList();
            return PartialView(hobbies);
        }
        public PartialViewResult Certificates()
        {
            var certificates = db.TblSertificates.ToList();
            return PartialView(certificates);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(TblMessage t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblMessage.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}