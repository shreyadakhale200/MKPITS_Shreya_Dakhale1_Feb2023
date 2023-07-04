using ItemDetailsInsertDelete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItemDetailsInsertDelete.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index(ItemModel ilist)
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            ItemDetailsDbHandler IHandler = new ItemDetailsDbHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());
        }

        [HttpGet]
        public ActionResult Create(ItemModel ilist)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ItemModel ilist)
        {

        }
    }
}