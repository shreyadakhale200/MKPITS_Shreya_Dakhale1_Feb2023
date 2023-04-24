using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance_userInput
{
    internal class Program
    {
        class person
        {
            string name;
            int roll_no;
            string Company_offer;
            public void getData(string name, int roll_no, string company_offer) //method overloading
            {
                this.name = name;
                this.roll_no = roll_no;
                this.Company_offer = company_offer;
            }
            public void displayData() // method overriding
            {
                Console.WriteLine("Name : " + this.name);
                Console.WriteLine("Roll no : " + this.roll_no);
                Console.WriteLine("Company offer : " + this.Company_offer);
            }
        }
        class student : person
        {
            double marks;
            char section;
            string school;

            public void getData(double marks, char section, string school,string name, int roll_no,string company_offer) // merthod overloading
            {
                this.marks = marks;
                this.section = section;
                this.school = school;
                getData(name, roll_no, company_offer); // to access getData from person class
            }
            public void displayData() // method overriding
            {
                Console.WriteLine("Marks : " + this.marks);
                Console.WriteLine("Section : " + this.section);
                Console.WriteLine("School : " + this.school);
                base.displayData(); // to access display from person class
            }
        }
        static void Main(string[] args)
        {
            student student1 = new student();

            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your roll no : ");
            int roll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Company offer : ");
            string company_offer = Console.ReadLine();

            Console.WriteLine("Enter your Marks : ");
            double marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your section: ");
            char section = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter your school : ");
            string school = Console.ReadLine();

            student1.getData(name, roll_no,company_offer,marks,section,school);
        }
    }
}
