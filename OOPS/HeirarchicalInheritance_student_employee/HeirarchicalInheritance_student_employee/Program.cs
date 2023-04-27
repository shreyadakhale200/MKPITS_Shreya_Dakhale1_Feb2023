using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace HeirarchicalInheritance_student_employee
{

    class person
    {
        string name;
        string address;
        int age;

        public void getData(string name, string address,int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public void Displaydata()
        {
            Console.WriteLine("Your name is : " + name);
            Console.WriteLine("Your address is : " + address);
            Console.WriteLine("Your age is : " +  age);
        }
    }
    class student:person
    {
        int roll_no;
        int marks;

        public void getData(string name,string address,int age,int roll_no,int marks)
        {
            this.roll_no = roll_no;
            this.marks = marks;
            getData(name, address, age);

        }
        public void Displaydata()
        {
            Console.WriteLine("Your roll no is : " + roll_no);
            Console.WriteLine("Your marks are : " + marks);
            base.Displaydata();
        }

    }
    class employee:person
    {
        int empno;
        int salary;

        public void getData(string name,string address,int age,int empno,int salary)
        {
            this.empno = empno;
            this.salary = salary;
            getData(name,address,age);
        }
        public void Displaydata()
        {
            Console.WriteLine("Your emp no is : " + empno);
            Console.WriteLine("Your salary are : " + salary);
            base.Displaydata();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            Console.WriteLine("--------------------------student details---------------------------");
            std.getData("Mahima", "Nagpur", 23,78,99);
            std.Displaydata();

            employee emp = new employee();
            Console.WriteLine("--------------------------employee details--------------------------");
            emp.getData("Mahima", "Dubai", 22, 87, 100000);
            emp.Displaydata();

            Console.ReadKey();
        }
    }
}
