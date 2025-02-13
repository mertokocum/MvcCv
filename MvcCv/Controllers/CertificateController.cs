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
    }
}