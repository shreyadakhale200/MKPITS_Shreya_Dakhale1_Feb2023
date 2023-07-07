using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProductCategoryMVC.Models
{
    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
        }

        public virtual DbSet<CategoryDetails> CategoryDetails { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryDetails>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductDetails>()
                .Property(e => e.Productname)
                .IsUnicode(false);
        }
    }
}
