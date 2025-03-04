using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class InterestController : Controller
    {
        // GET: Interest
        GenericRepository<TblHobbies> repo = new GenericRepository<TblHobbies>();

        public ActionResult Index()
        {
            var interest = repo.List();

            return View(interest);
        }
        [HttpGet]
        public ActionResult AddInterest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInterest(TblHobbies p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddInterest");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteInterest(int id)
        {
            var interest = repo.Find(x => x.ID == id);
            repo.TDelete(interest);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditInterest(int id)
        {
            var interest = repo.Find(x => x.ID == id);
            return View(interest);
        }
        [HttpPost]
        public ActionResult EditInterest(TblHobbies t)
        {
            if (!ModelState.IsValid)
            {
                return View("EditInterest");
            }
            var interest = repo.Find(x => x.ID == t.ID);
            interest.Detail1 = t.Detail1;
            interest.Detail2 = t.Detail2;
            
            repo.TUpdate(interest);
            return RedirectToAction("Index");
        }
    }
}