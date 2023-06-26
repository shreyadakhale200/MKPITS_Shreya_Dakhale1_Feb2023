using AssignmentMVCform.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentMVCform.Controllers
{
    public class EvenOdd1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EvenOdd(EvenOdd e)
        {
            ViewBag.number = e.number;
            if (e.number % 2 == 0)
            {
                ViewBag.result = "Even number";
            }
            else
            {
                ViewBag.result = "Odd number";
            }
            return View();
        }
    }
}
