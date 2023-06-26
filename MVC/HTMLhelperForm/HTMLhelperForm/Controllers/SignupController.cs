using HTMLhelperForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTMLhelperForm.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index(SignupModel s)
        {
            ViewBag.username = s.username;
            ViewBag.password = s.password;
            return View();
        }
    }
}
