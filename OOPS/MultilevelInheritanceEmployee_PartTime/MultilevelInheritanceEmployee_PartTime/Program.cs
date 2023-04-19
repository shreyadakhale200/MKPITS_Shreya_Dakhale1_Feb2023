using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceEmployee_PartTime
{
    internal class Program
    {
        class person
        {
            string name;
            int age;

            public void getData(string name,int age)
            {
                this.name = name;
                this.age = age;
            }
            public void getdisplay()
            {
                Console.WriteLine("name : " + name);
                Console.WriteLine("age : " + age);
            }
        }
        class employee:person
        {
            int empno;
            int salary;

            public void getData(int empno,int salary)
            { 
                this.empno = empno;
                this.salary = salary; 
            }
            public void getDisplay()
            {
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
