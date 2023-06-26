using AssignmentMVCform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssignmentMVCform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(AdditionModel a)
        {
            ViewBag.number1 = a.number1;
            ViewBag.number2 = a.number2;
            ViewBag.result = a.number1 + a.number2;
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