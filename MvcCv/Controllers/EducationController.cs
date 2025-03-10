﻿using System;
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
            if(!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var education=repo.Find(x=>x.ID==id);
            repo.TDelete(education);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            var education = repo.Find(x => x.ID == id);
            return View(education);
        }
        [HttpPost]
        public ActionResult EditEducation(TblEducation t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditEducation");
            }
            var education = repo.Find(x => x.ID == t.ID);
            education.Title = t.Title;
            education.Sub_Title = t.Sub_Title;
            education.Sub_Title2 = t.Sub_Title2;
            education.GNO = t.GNO;
            education.Date = t.Date;
            repo.TUpdate(education);
            return RedirectToAction("Index");
        }
    }
}