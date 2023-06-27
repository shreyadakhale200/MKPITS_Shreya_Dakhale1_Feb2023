using Microsoft.AspNetCore.Mvc;
using RadiobuttonFormMVC.Models;
using System.Diagnostics;

namespace RadiobuttonFormMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(RadioButtonModel r)
        {
            string Check = null;
           
            if (r.category == "Tea")
            {
                Check = "Tea";
            }
            else if (r.category == "Laundary")
            {
                Check = "Laundary" ;
            }
            else if (r.category == "Breakfast")
            {
                Check = "Breakfast";
            }
            ViewBag.Check = Check;
            return View();

        }

        public IActionResult ArithmaticOperation(ArithmaticOperationsModel a)
        {
            ViewBag.number1 = a.number1;
            ViewBag.number2 = a.number2;
            int Calculate = 0;
            if(a.Operator == "Add")
            {
                Calculate = a.number1 + a.number2;
            }
            else if(a.Operator == "Subtract")
            {
                Calculate = a.number1 - a.number2;
            }
            else if(a.Operator == "Multiply")
            {
                Calculate = a.number1 * a.number2;
            }
            ViewBag.Calculate = Calculate;
            return View();
        }

        public IActionResult SignUp(SignupModel s)
        {
            ViewBag.username = s.username;
            ViewBag.password = s.password;
            ViewBag.email = s.email;
            //Radiobutton
            string Check = null;
            if(s.gender == "Female")
            {
                Check = "Female";
            }
            else if(s.gender == "Male")
            {
                Check = "Male";
            }
            ViewBag.Check = Check;  

            //Checkbox
            if(s.subject1 == true)
            {
                ViewBag.subject1 = "Dotnet";
            }
            if (s.subject2 == true)
            {
                ViewBag.subject2 = "Java";
            }

            return View();
        }

        public IActionResult AccountDetails(Account a)
        {
            ViewBag.customername = a.customername;
            int amount = 0;
            int balance = 1000;
            string status;
            amount = a.amount;

            // Uncomment if you want to handle negative amounts
            if (a.amount < 0)
            {
                status = "Invalid Amount";
                ViewBag.balance = status;
            }
            else
            {
                if (a.accounttype == "deposit")
                {
                    balance = balance + a.amount;
                }
                else if (a.accounttype == "withdrawl")
                {
                    balance = balance - a.amount;
                }

                ViewBag.balance = balance;
            }



            return View();
        }


        public IActionResult Attendance(AttendanceModel a)
        {
        
            ViewBag.batch = a.Batch;

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