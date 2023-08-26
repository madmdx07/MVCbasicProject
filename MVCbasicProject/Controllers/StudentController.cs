using MVCbasicProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbasicProject.Controllers
{
    public class StudentController : Controller
    {
        StudentDbEntities db = new StudentDbEntities();
        // GET: Student
        public ActionResult Index()
        {
            List<tblStudent> students = db.tblStudents.ToList();
            return View(students);
        }

        public ActionResult ClassStudents(int cId)
        {
            List<tblStudent> students = db.tblStudents.Where(id => id.Grade == cId).ToList();
            return View(students);
        }
    }
}