using AssignmentMVCform.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentMVCform.Controllers
{
    public class ProductInfoController : Controller
    {
        public IActionResult ProductInformation(Product p)
        {
            ViewBag.ProductName = p.ProductName;
            ViewBag.ProductPrice = p.ProductPrice;
            ViewBag.Quantity = p.Quantity;
            p.TotalPrice = p.ProductPrice * p.Quantity;
            ViewBag.TotalPrice = p.TotalPrice;
            return View();
        }
    }
}
