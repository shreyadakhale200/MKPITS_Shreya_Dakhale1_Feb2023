using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationModelControlller.Models;

namespace ValidationModelControlller.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
      
        public IActionResult StudentDetails(StudentModel sm)
        {
            if(string.IsNullOrEmpty(sm.Name))
            {
                ModelState.AddModelError("Name", "Name Required");
                
            }
            if(sm.Age < 0 || sm.Age > 120)
            {
                ModelState.AddModelError("Age", "Enter Valid Age");
            }
            
            if(ModelState.IsValid)
            {
                ViewBag.Name = sm.Name;
                ViewBag.Age = sm.Age;   
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.Age = "No Data";
            }
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