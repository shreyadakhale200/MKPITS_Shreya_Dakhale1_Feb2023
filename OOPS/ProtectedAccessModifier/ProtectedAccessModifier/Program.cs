using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedAccessModifier
{
    class School
    {
        //public int Roll_no; // field having public access modifier
        //public string Name; // Field having public access modifier 
        //protected static String Principal = "Bhansali"; // Field having protected access modifier
        //protected static string SchoolName = "Government Ploytechnic"; // field having protected access modifier
      
        protected static String Principal; // Field having protected access modifier
        public static string SchoolName; // field having protected access modifier

    }
    class student:School
    {
        public int Roll_no; // field having public access modifier
        public string Name; // Field having public access modifier 
        public student(int Roll_no,string Name) 
        { 
            this.Roll_no = Roll_no; 
            this.Name = Name;
            //this.Principal = Principal;
        }
        public void display()
        {
            Console.WriteLine("Roll number : " +  Roll_no);
            Console.WriteLine("Name : " +  Name);
            Console.WriteLine("School Name : " + SchoolName);
            Console.WriteLine("Principal : " + Principal);
          
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(School.Principal); //'School.Principal' is inaccesible due to its protection level
            student s = new student(32,"shreya");
            //s.Principal = "bakshi";
            //s.Name = "MODER";
            s.display();
        }
    }
}
