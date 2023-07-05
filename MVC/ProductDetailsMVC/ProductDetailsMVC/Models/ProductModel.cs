using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetailsMVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
    }
}