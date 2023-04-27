using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed class Employee
    {
        public void ShowData()
        {
            Console.WriteLine("Hello from Employee public");
        }
        public static void DisplayData()
        {
            Console.WriteLine("Hello from Employee static");
        }

    }
    //class PartTime : Employee
    //{
        //'PartTime':cannot derive from sealed type employee
    //}

  internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.ShowData();
            Employee.DisplayData();
        }
    }
}
