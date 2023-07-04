using ItemDatabaseConnectionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using ItemDatabaseConnectionMVC.Models;

namespace ItemDatabaseConnectionMVC.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // *************** Add new item **************
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemModel ilist)
        {
            if (ModelState.IsValid)
            {
                ItemDetailsDbHandler db = new ItemDetailsDbHandler();
                if (db.InsertItem(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }

            }
            return View();
        }

    }
}
