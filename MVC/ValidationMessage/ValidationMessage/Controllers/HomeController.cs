using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationMessage.Models;

namespace ValidationMessage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(StudentModel sm)
        {
            if(ModelState.IsValid)
            {
                return View(sm);
            }
            else 
            { 
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult ValidationSummary(UserModel um)
        {
            ViewBag.UserName = um.UserName;
            ViewBag.Mobile = um.Mobile;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}