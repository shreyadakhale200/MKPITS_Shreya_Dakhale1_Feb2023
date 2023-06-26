using AssignmentMVCform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssignmentMVCform.Controllers
{
    public class SalaryDesignationController : Controller
    {
        public IActionResult SalaryDifference()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalaryDifference(SalaryDiff s)
        {
            ViewBag.empname = s.empname;
            s.basicsalary = 15000;

            if (s.designation == "Manager")
            {
                s.totalsalary = s.basicsalary + 10000;
                ViewBag.totalsalary = s.totalsalary;
            }
            else if (s.designation == "Clerk")
            {
                s.totalsalary = s.basicsalary + 5000;
                ViewBag.totalsalary = s.totalsalary;
            }
            else if (s.designation == "Peon")
            {
                s.totalsalary = s.basicsalary + 1000;
                ViewBag.totalsalary = s.totalsalary;
                
            }
            ViewBag.designation = s.designation;

            return View();
        }
    }
}
