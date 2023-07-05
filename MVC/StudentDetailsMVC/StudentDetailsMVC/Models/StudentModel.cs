using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDetailsMVC.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}