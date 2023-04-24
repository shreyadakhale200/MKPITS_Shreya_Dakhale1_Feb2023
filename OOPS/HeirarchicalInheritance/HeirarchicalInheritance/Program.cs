using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirarchicalInheritance
{
    internal class Program
    {
        class person
        {
            public string name;
            public string address;
        }
        class student:person
        {
            public int roll_no;
            public int marks;
        }
        class employee : person
        {
            public int salary;
            public int empno;
        }
        static void Main(string[] args)
        {
            student std1 = new student();
            std1.name = "Manush";
            std1.address = "Nagpur";
            std1.roll_no = 43;
            std1.marks = 87;
            Console.WriteLine("----------------------Student Details-----------------------");
            Console.WriteLine(std1.name);
            Console.WriteLine(std1.address);
            Console.WriteLine(std1.roll_no);
            Console.WriteLine(std1.marks);
            
            employee emp1 = new employee();
            emp1.name = "Basil";
            emp1.address = "France";
            emp1.empno = 65;
            emp1.salary = 78000;
            Console.WriteLine("----------------------Employee Details-----------------------");
            Console.WriteLine(emp1.name);
            Console.WriteLine(emp1.address);
            Console.WriteLine(emp1.salary);
            Console.WriteLine(emp1.empno);
            Console.ReadKey();
        }
    }
}
