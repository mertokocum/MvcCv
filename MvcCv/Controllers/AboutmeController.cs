using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class AboutmeController : Controller
    {
        // GET: Aboutme
        DbCvEntities db = new DbCvEntities();
        GenericRepository<TblAboutme> repo = new GenericRepository<TblAboutme>();
        [HttpGet]
        public ActionResult Index()
        {
            var aboutme = repo.List();
            return View(aboutme);
        }
        [HttpPost]
        public ActionResult Index(TblAboutme p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.name = p.name;
            t.surname = p.surname;
            t.address = p.address;
            t.phone = p.phone;
            t.mail_address = p.mail_address;
            t.about_me = p.about_me;
            t.Photo = p.Photo;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        public ActionResult CancelEdit()
        {
            return RedirectToAction("Index");
        }
        


    }
}