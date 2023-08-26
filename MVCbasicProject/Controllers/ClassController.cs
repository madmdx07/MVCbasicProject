using MVCbasicProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbasicProject.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            StudentDbEntities db = new StudentDbEntities();
            List<tblClass> classes = db.tblClasses.ToList();
            return View(classes);
        }
    }
}