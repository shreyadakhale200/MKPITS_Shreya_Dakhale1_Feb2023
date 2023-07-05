using EmployeeDetailsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDetailsMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDBHandler employeeDBHandler = new EmployeeDBHandler();
            ModelState.Clear();
            return View(employeeDBHandler.GetListItem());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel ilist)
        {
            if(ModelState.IsValid)
            {
                EmployeeDBHandler IHandler = new EmployeeDBHandler();
                if(IHandler.InsertEmployee(ilist))
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
            EmployeeDBHandler IHandler = new EmployeeDBHandler();
            return View(IHandler.GetListItem().Find(EmployeeModel => EmployeeModel.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(int id,EmployeeModel ilist)
        {
            EmployeeDBHandler IHandler = new EmployeeDBHandler();
            IHandler.UpdateEmployee(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            EmployeeDBHandler IHandler = new EmployeeDBHandler();
            return View(IHandler.GetListItem().Find(EmployeeModel => EmployeeModel.Id==id));    
        }

        [HttpPost]
        public ActionResult Delete(int id,EmployeeModel ilist)
        {
            EmployeeDBHandler IHandler = new EmployeeDBHandler();
            IHandler.DeleteEmployee(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            EmployeeDBHandler IHandler = new EmployeeDBHandler();
            return View(IHandler.GetListItem().Find(EmployeeModel => EmployeeModel.Id==id));    
        }
    }
}