

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_RuntimePolymorphism
{
    class Employee
    {
       public int bonus = 500;
       public virtual int calculateSalary(int salary)
        {
            return 0;
        }
    }
   class Manager:Employee
    { 
        public override int calculateSalary(int salary)
        {
            salary = bonus + salary;    
            return salary;
        }
    }

    class Engineer : Employee
    {
        public override int calculateSalary(int salary)
        {
            salary = bonus + salary;
            return salary;
        }
    }

    class Salesperson:Employee
    {
        public override int calculateSalary(int salary)
        {
            salary = bonus + salary;
            return salary;
        }
    }
}
