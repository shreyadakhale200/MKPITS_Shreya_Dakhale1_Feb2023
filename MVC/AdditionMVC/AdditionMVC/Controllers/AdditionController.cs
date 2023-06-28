using AdditionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdditionMVC.Controllers
{
    public class AdditionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Add a)
        {
            ViewBag.number1 = a.number1;
            ViewBag.number2 = a.number2;

            int add = a.number1 + a.number2;
            ViewBag.result = add;

            //TempData["number1"] = a.number1;
            //return Redirect("Addition/Redirect");

            TempData["number1"] = a.number1;
            return Redirect("/Addition/Redirect");

            //return View();
        }

        public IActionResult htmlActionLink()
        {
            return View();
        }
        public IActionResult Redirect()
        {
            return View();
        }
        
    }
}
