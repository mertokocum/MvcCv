using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        GenericRepository<TblSkills> repo = new GenericRepository<TblSkills>();
        public ActionResult Index()
        {
            var skills=repo.List();
            return View(skills);
        }
    }
}