namespace EnityFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookTable")]
    public partial class bookTable
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string BookName { get; set; }

        [StringLength(50)]
        public string Price { get; set; }
    }
}
