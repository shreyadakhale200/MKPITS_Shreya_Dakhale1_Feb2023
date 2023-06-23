using Microsoft.AspNetCore.Mvc;

namespace MVCIntroduction.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
