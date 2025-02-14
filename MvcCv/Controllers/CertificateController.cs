using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate
        GenericRepository<TblSertificates> repo = new GenericRepository<TblSertificates>();
        public ActionResult Index()
        {
            var certificate = repo.List();
            return View(certificate);
        }
        [HttpGet]
        public ActionResult GetCertificate(int id)
        {
            var certificate = repo.Find(x => x.ID == id);
            return View(certificate);
        }
        [HttpPost]
        public ActionResult GetCertificate(TblSertificates t)
        {
            var certificate = repo.Find(x => x.ID == t.ID);
            certificate.Detail = t.Detail;
            certificate.Date = t.Date;
            repo.TUpdate(certificate);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCertificate(TblSertificates p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteCertificate(int id)
        {
            var certificate = repo.Find(x => x.ID == id);
            repo.TDelete(certificate);
            return RedirectToAction("Index");
        }
        public ActionResult CancelEdit()
        {
            return RedirectToAction("Index");
        }
    }
}