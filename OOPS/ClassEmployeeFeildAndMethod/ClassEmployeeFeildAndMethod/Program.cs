using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClassEmployeeFieldAndMethod
{
    class Employee
    {
        string name;
        double Emp_id;
        long salary;

        public void getEmployeeInfo()
        {
            name = "Mahima";
            Emp_id = 5345395384839;
            salary = 78000;
        }

        public void displayEmployeeInfo()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("Employee id : " + Emp_id);
            Console.WriteLine("Employee salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getEmployeeInfo();
            emp.displayEmployeeInfo();
            Console.ReadKey();
        }
    }
}
