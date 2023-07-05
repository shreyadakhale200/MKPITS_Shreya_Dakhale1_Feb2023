using StudentDetailsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDetailsMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(StudentModel ilist)
        {
            StudentDBHandler IHandler = new StudentDBHandler();
            ModelState.Clear();
            return View(IHandler.GetStudentList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentModel ilist)
        {
            if(ModelState.IsValid)
            {
                StudentDBHandler IHandler = new StudentDBHandler();
                if(IHandler.InsertStudentDetails(ilist))
                {
                    ViewBag.message = "Inserted Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            StudentDBHandler IHandler = new StudentDBHandler();
            return View(IHandler.GetStudentList().Find(StudentModel => StudentModel.id == id));
        }

        [HttpPost]
        public ActionResult Edit(int id,StudentModel ilist)
        {
            StudentDBHandler IHandler = new StudentDBHandler();
            IHandler.UpdateStudentDetails(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentDBHandler IHandler = new StudentDBHandler();
            return View(IHandler.GetStudentList().Find(StudentModel=>StudentModel.id == id));
        }

        [HttpPost]
        public ActionResult Delete(int id,StudentModel ilist)
        {
            StudentDBHandler IHandler = new StudentDBHandler();
            IHandler.DeleteStudentDetails(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            StudentDBHandler IHandler = new StudentDBHandler();
            return View(IHandler.GetStudentList().Find(StudentModel => StudentModel.id == id));

        }
    }
}