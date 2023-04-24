//wap to accept empno, empname , designation (suppose manager, clerk, peon) ,calculate and display bonus ie
//10000 for manager
//5000 for clerk
//2000 for peon

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positionEmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double employee_no;
            string employee_name;
            const double salary = 15000;
            string designation;

            Console.WriteLine("Enter employee number : ");
            employee_no = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter employee Name : ");
            employee_name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter your Designation : ");
            designation = Convert.ToString(Console.ReadLine());  

            if(designation == "manager")
            {
                double manager = salary + 10000;
                Console.WriteLine("Manager Salary : " + manager);
            }
            else if (designation == "clerk")
            {
                double clerk = salary + 5000;
                Console.WriteLine("Clerk Salary : " + clerk);      
            }
            else if(designation == "peon")
            {
                double peon = salary + 2000;
                Console.WriteLine("Peon Salary : " + peon);
            }
            Console.ReadKey();
        }
    }
}
