//wap to accept empno, empname , basicsalary and calculate, hra ie 32% of basic, da ie 45% of basic. Display empno, empname, hra, da, total_salary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long employee_no;
            string employee_name;
            double employee_salary;
            //House Rent Allowance hra 32%
            //Dearness allowance da 45%
            Console.WriteLine("Enter Employee number : ");
            employee_no = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Employee name : ");
            employee_name = Convert.ToString(Console.ReadLine());  
            
            Console.WriteLine("Enter Employee Salary : ");
            employee_salary = Convert.ToDouble(Console.ReadLine());

            const double hra = 0.32f;
            const double da = 0.45f;

            double basicSalary = employee_salary + hra + da;

            Console.WriteLine("Employee No. " + employee_no);
            Console.WriteLine("Employee Name. " + employee_name);
            Console.WriteLine("Employee Salary. " + basicSalary);
            Console.ReadKey();

        }
    }
}
