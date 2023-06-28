using CheckboxFormMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckboxFormMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(CheckboxModel c)
        {
            ViewBag.Tea = c.Tea.ToString();
            ViewBag.Laundary = c.Laundary.ToString();
            ViewBag.Breakfast = c.Breakfast.ToString();
            return View();
        }
        
        public IActionResult Arithmatic(ArithmaticOperationModel a)
        {
            ViewBag.Number1 = a.number1;
            ViewBag.Number2 = a.number2;
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            if(a.Add == true)
            {
                result1 = a.number1 + a.number2;
                ViewBag.Result1 = result1;
            }
            if(a.Subtract == true) 
            {
                result2 = a.number1 - a.number2;
                ViewBag.Result2 = result2;
            }
            if(a.Multiply == true)
            {
                result3 = a.number1 * a.number2;
                ViewBag.Result3 = result3;
            }

            TempData["ADD"] = a.number1;
            //TempData["SUBTRACT"] = result2;
            //TempData["MULTIPLY"] = result3;
            //return View();
            return Redirect("/Home/");
        }

        public ActionResult EmployeeSal(EmployeeSalaryModel e)
        {
            ViewBag.empname = e.empname;
            ViewBag.basicsalary = e.basicsalary;
            double hra = 0.25;
            double da = 0.45;
            double ta = 0.15;
            //HRA - (25%) House Rent Allowance
            if(e.hra == true)
            {
                hra = (e.basicsalary * hra);
                ViewBag.hra = hra;
            }
            if(e.da == true)
            {
                da = (e.basicsalary * da);
                ViewBag.da = da;
            }
            if(e.ta == true)
            {
                ta = (e.basicsalary *  ta);
                ViewBag.ta = ta;
            }

            double total = e.basicsalary + hra + da;
            ViewBag.total = total;
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}