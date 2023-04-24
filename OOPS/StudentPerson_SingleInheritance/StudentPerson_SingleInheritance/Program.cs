using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerson_SingleInheritance
{
    internal class Program
    {
        class person
        {
            string name;
            int age;
            string address;
            int roll_no;

            public void getData(string  name, int age, string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }

            public void displayData()
            {
                Console.WriteLine("Name : " +  this.name);
                Console.WriteLine("Age : " + this.age);
                Console.WriteLine("Address : " +  this.address);
            }

        }
        class student : person 
        {
            string school;
            double marks;

            public void getData(string school, double marks, string name, int age, string address)
            {
                this.school = school;
                this.marks = marks;
                getData(name, age, address);
            }
            public void displayData()
            {
                Console.WriteLine("School name :" + this.school);
                Console.WriteLine("Marks : " + this.marks);
                base.displayData();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------student 1 Details-------------------------------");
            student stud1 = new student();
            stud1.getData("Panchgani", 87, "Gomati", 43, "Nagpur");
            stud1.displayData();

            Console.WriteLine("---------------------------------student 2 Details-------------------------------");
            student stud2 = new student();
            stud2.getData("Oxford University", 100, "Muzahid Khan", 34, "Nagpur");
            stud2.displayData();
            
            Console.WriteLine("---------------------------------student 3 Details-------------------------------");
            student stud3 = new student();
            stud3.getData("Harvard University", 100, "Neha Thakur", 24, "Nagpur");
            stud3.displayData();
            
            
            Console.WriteLine("---------------------------------student 4 Details-------------------------------");
            student stud4 = new student();
            stud4.getData("University of Canada", 120, "Ashish Lilhare", 25, "Nagpur");
            stud4.displayData();
            
            
            Console.WriteLine("---------------------------------student 5 Details-------------------------------");
            student stud5 = new student();
            stud5.getData("Symbiosis", 999, "Rupali Barde", 22, "Nagpur");
            stud5.displayData();
            Console.ReadKey();
        }
    }
}
