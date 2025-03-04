using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        GenericRepository<TblMessage> repo = new GenericRepository<TblMessage>();
        public ActionResult Index()
        {
            var messages = repo.List();
            return View(messages);
        }
    }
}