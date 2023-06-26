using AssignmentMVCform.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentMVCform.Controllers
{
    public class ArithmaticOperatorsController : Controller
    {
        public IActionResult ArithmaticOperations(Operators o)
        {
            ViewBag.number1 = o.number1;
            ViewBag.number2 = o.number2;
            if(o.operator1 == "+")
            {
                o.operation = o.number1 + o.number2;
                ViewBag.operation = o.operation;
            }
            else if(o.operator1 == "-")
            {
                o.operation = o.number1 - o.number2;
                ViewBag.operation = o.operation;
            }
            else if(o.operator1 == "*")
            {
                o.operation = o.number1 * o.number2;
                ViewBag.operation = o.operation;
            }
            else if(o.operator1 == "/")
            {
                o.operation = o.number1 / o.number2;
                ViewBag.operation = o.operation;
            }
            return View();
        }
    }
}
