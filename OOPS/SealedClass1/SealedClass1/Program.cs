using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass1
{
    sealed class student
    {
        public int rollno = 34;
        public string name = "Bakshi";
        public void DisplayData()
        { 
            Console.WriteLine("Roll no from a student class : " +  rollno);
            Console.WriteLine("Name from a student class : " +  name);
        }
    }
    class Employee //: student
    {
        //Employee cannot derive from sealed type student 
        public string Empname = "Mahesh";
        public int empid = 23;

        public void DisplayData()
        {
            Console.WriteLine("Emp name from Employee class : " + Empname);
            Console.WriteLine("Emp id from Employee class : " +  empid);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.DisplayData();

            Employee emp = new Employee();
            emp.DisplayData();

            Console.ReadKey();
        }
    }
}
