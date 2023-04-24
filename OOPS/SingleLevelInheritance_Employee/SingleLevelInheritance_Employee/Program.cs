using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritance_Employee
{
    internal class Program
    {
        class employee
        {
            double employee_id;
            string name;

            public void employeeGetData(int employee_id, string name)
            {
                this.employee_id = employee_id; 
                this.name = name;
            }
            public void employeeDisplayData()
            {
                Console.WriteLine("Employee id : " + employee_id);
                Console.WriteLine("Employee name : " + name);
            }
        }
        class programmer : employee 
        {
            int salary;
            int bonus;
            string promotion;

            public void ProgrammerGetData(int sal, int bonus,string promoteTo)
            {
                this.salary = sal;
                this.bonus = bonus;
                this.promotion = promoteTo;
            }
            public void ProgrammerDisplayData()
            {
                Console.WriteLine("Salary : " + salary);
                Console.WriteLine("Bonus : " + bonus);
                Console.WriteLine("Promotiom : " + promotion);
            }
        }

        static void Main(string[] args)
        {
            programmer programmer1 = new programmer();
            programmer1.employeeGetData(435, "Monal");
            programmer1.ProgrammerGetData(45000, 4000, "Senior Developer");
            programmer1.employeeDisplayData();
            programmer1.ProgrammerDisplayData();
            Console.ReadKey();
        }
    }
}
