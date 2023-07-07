using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ProductCategoryMVC.Models;
namespace ProductCategoryMVC.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            bindCategory();
            return View();
        }


        #region==========Category==========
            public void bindCategory()
            {
                ProductModel modelDemo = new ProductModel();        // Create an object of ProductModel class
                var category = modelDemo.CategoryDetails.ToList();     // We are taking values from CategoryDetails class and storing it in category variable
                List<SelectListItem> li = new List<SelectListItem>();   // We are Saving all the values of CategoryDetails in a List

                li.Add(new SelectListItem { Text = "--Select Category--", Value = "0" });
                foreach (var m in category)
                {

                    li.Add(new SelectListItem { Text = m.Name, Value = m.Categoryid.ToString() });
                    ViewBag.category = li;
                }
            }
        #endregion


        public JsonResult getProduct(int id)
        {
            ProductModel modelDemo = new ProductModel();
            var ddlProduct = modelDemo.ProductDetails.Where(x => x.Categoryid == id).ToList();
            List<SelectListItem> liproducts = new List<SelectListItem>();

            liproducts.Add(new SelectListItem { Text = "--Select Product--", Value = "0" });
            if (ddlProduct != null)
            {
                foreach (var x in ddlProduct)
                {
                    liproducts.Add(new SelectListItem { Text = x.Productname, Value = x.Productid.ToString() });
                }
            }
            return Json(new SelectList(liproducts, "Value", "Text", JsonRequestBehavior.AllowGet));
        }

    }


}