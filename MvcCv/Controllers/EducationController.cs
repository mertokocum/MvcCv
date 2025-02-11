using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        GenericRepository<TblEducation> repo = new GenericRepository<TblEducation>();

        public ActionResult Index()
        {
            var education = repo.List();

            return View(education);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(TblEducation p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        
    }
}