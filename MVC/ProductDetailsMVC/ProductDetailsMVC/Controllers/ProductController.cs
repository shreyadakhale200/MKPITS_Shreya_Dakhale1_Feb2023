using ProductDetailsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace ProductDetailsMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(ProductModel ilist)
        {
            ProductDBHandler productDBHandler = new ProductDBHandler();
            ModelState.Clear();
            return View(productDBHandler.GetProductList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductModel ilist)
        {
            if(ModelState.IsValid)
            {
                ProductDBHandler IHandler = new ProductDBHandler();
                if(IHandler.InsertProduct(ilist))
                {
                    ViewBag.message = "Inserted Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ProductDBHandler IHandler = new ProductDBHandler();
            return View(IHandler.GetProductList().Find(ProductModel =>  ProductModel.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(int id,ProductModel ilist)
        {
            ProductDBHandler IHandler = new ProductDBHandler();
            IHandler.InsertProduct(ilist);
            return RedirectToAction("Index");   
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ProductDBHandler IHandler = new ProductDBHandler();
            return View(IHandler.GetProductList().Find(ProductModel =>ProductModel.Id == id));  
        }

        [HttpPost]
        public ActionResult Delete(int id,ProductModel ilist)
        {
            ProductDBHandler IHandler = new ProductDBHandler();
            IHandler.DeleteProduct(ilist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            ProductDBHandler IHandler = new ProductDBHandler();
            return View(IHandler.GetProductList().Find(ProductModel=>ProductModel.Id == id));   
        }
        


    }
}