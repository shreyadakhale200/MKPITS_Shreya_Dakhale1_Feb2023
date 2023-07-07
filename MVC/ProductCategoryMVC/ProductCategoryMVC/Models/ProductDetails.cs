namespace ProductCategoryMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Productid { get; set; }

        [StringLength(50)]
        public string Productname { get; set; }

        public int? Categoryid { get; set; }

        public virtual CategoryDetails CategoryDetail { get; set; }
    }
}
