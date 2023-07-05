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
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ItemModel ilist)
        {
            if (ModelState.IsValid)
            {
                ItemDetailsDbHandler db = new ItemDetailsDbHandler();
                if (db.InsertDetails(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }

            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDetailsDbHandler iHandler = new ItemDetailsDbHandler();
            return View(iHandler.GetItemList().Find(ItemModel => ItemModel.Id == id));  
        }

        [HttpPost]
        public ActionResult Edit(int id,ItemModel ilist)
        {
            ItemDetailsDbHandler iHandler = new ItemDetailsDbHandler();
            iHandler.UpdateDetails(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ItemDetailsDbHandler IHandler = new ItemDetailsDbHandler();
            return View(IHandler.GetItemList().Find(ItemModel => ItemModel.Id == id));
        }

        [HttpPost]

        public ActionResult Delete(int id,ItemModel ilist)
        {
            ItemDetailsDbHandler itemDetailsDbHandler = new ItemDetailsDbHandler();
            itemDetailsDbHandler.DeleteDetails(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            ItemDetailsDbHandler IHandler = new ItemDetailsDbHandler();
            return View(IHandler.GetItemList().Find(ItemModel => ItemModel.Id == id));
        }
    }
}