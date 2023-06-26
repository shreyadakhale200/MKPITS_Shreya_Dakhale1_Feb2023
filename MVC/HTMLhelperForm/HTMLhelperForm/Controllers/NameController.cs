using HTMLhelperForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTMLhelperForm.Controllers
{
    public class NameController : Controller
    {
       
        public IActionResult Index(UserModel u)
        {
            ViewBag.Name = u.Name;
            return View();
        }


    }
}
