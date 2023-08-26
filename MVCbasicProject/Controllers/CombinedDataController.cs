using MVCbasicProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbasicProject.Controllers
{
    public class CombinedDataController : Controller
    {
        StudentDbEntities db = new StudentDbEntities();
        // GET: CombinedData
        public ActionResult Index()
        {
            List<tblClass> classes = db.tblClasses.ToList();
            List<tblStudent> students = db.tblStudents.ToList();

            List<Combined> combindeData = classes
                .Join(students, a => a.Id, b => b.Id, (a, b) => new Combined
                {
                    Name = b.Name,
                    Gender = b.Gender,
                    ClassTeacher = a.ClassTeacher,
                    Grade = b.Grade
                }).ToList();
            return View(combindeData);
        }
    }
}