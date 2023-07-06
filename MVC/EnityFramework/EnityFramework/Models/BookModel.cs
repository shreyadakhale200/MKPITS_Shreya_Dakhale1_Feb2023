using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EnityFramework.Models
{
    public partial class BookModel : DbContext
    {
        public BookModel()
            : base("name=BookModel")
        {
        }

        public virtual DbSet<bookTable> bookTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
