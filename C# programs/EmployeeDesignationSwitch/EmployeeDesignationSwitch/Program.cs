//wap to accept empname and designation and using switch display bonus

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignationSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String emp_name,designation;
            int bonus=0;
            Console.WriteLine("Enter Employee Name : ");
            emp_name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Employee Designation : ");
            designation = Convert.ToString(Console.ReadLine());

            switch (designation)
            {
                case "manager":
                    bonus = 10000; 
                    break;

                case "clerk":
                    bonus = 5000;
                    break;

                case "peon":
                    bonus = 2000;
                    break;

                default:
                    Console.WriteLine("Invalid designation");
                    break;
            }
            Console.WriteLine("designation of " + emp_name + " is : " + designation);
            Console.WriteLine("Salary of " + designation + " is " +  bonus);
            Console.ReadKey();

        }
    }
}
