using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItemDetailsInsertDelete.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Decimal Price{ get; set; }
    }
}