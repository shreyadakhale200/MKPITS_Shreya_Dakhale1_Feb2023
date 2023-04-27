using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class student
    {
        public int Rollno;
        public string name;

        public student(int Rollno, string name) 
        {
            this.Rollno = Rollno;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Roll number : " + Rollno);
            Console.WriteLine("Name : " +  name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student(67,"Shreya");
            student student2 = new student(54, "Manish");
            student1.Display();
            student2.Display();
            Console.ReadKey();
        }
    }
}
