using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritance
{
    class University
    {
        public int roll_no;
        public string name;
    }
    class student : University 
    {
        public int student_id;
        public double parents_no;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.name = "Shreya";
            student1.roll_no = 54;
            student1.student_id = 132;
            student1.parents_no = 99794506596;
            Console.WriteLine("Name : " + student1.name);
            Console.WriteLine("Roll_no : " + student1.roll_no);
            Console.WriteLine("Student id : " + student1.student_id);
            Console.WriteLine("Parents no : " + student1.parents_no);
            Console.ReadKey();
        }
    }
}
