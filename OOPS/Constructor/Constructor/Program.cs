using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Student
    {
        public int rollNo;
        public string name;

        public Student(int rollNo, string name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }  
        public void display()
        {
            Console.WriteLine("Roll no : " +  rollNo);
            Console.WriteLine("Name : " +  name);
        }
   }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(34,"Shreya");
            //student.rollNo = 1;
            //student.name = "Shreya"; 
            student.display();
            Console.WriteLine();
        }
    }
}
