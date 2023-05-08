using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldEmployee
{
    class Employee
    {
        public int empno;   //public field
        public String name; //public field
        public static int count = 0;
        public static string CompanyName = "Fendahl";   //public static field

        public Employee(int empno, string name)   //creating a constructor
        {
            this.empno = empno; //accessing the fields declared in the class
            this.name = name;   //accessing the fields declared in the class
            count++;
        }
        public void Display()   //Display method
        {
            Console.WriteLine("Employee Number : " + empno);    //Displaying the Employee no
            Console.WriteLine("Employee name : " +  name);      //Displaying the Employee Name
            Console.WriteLine("Company Name : " +  CompanyName);//Displaying the Company Name
        }
    }
    class Manager:Employee
    {
        public Manager(int empno, string name) : base(empno, name)
        {
            this.empno = empno; //accessing the fields declared in the class
            this.name = name;   //accessing the fields declared in the class
            count++;
        }
        public void Display()   //Display method
        {
            Console.WriteLine("Employee Number : " + empno);    //Displaying the Employee no
            Console.WriteLine("Employee name : " + name);      //Displaying the Employee Name
            Console.WriteLine("Company Name : " + CompanyName);//Displaying the Company Name
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(123, "Shruti");  // instantiating an object named e1
            Employee e2 = new Employee(342, "Shweta");  // instantiating an object named e2 
            Manager m1 = new Manager(234, "Shahid");
            //Employee.CompanyName = "Modern";
            e1.Display();   //calling e1 
            e2.Display();   //calling e2
            Console.WriteLine("No of object : " + Employee.count);
            Console.WriteLine("Company : " + Employee.CompanyName);
            Console.ReadKey();
        }
    }
}
