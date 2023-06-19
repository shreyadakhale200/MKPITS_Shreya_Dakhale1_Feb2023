using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{

    class student
    {
        public string name;
        public int age;
        public int rollno;

        public void show(string studentName, int studentAge, int studentRollno)
        {
            name = studentName;
            age = studentAge;
            rollno = studentRollno;
        }

        public void display()
        {
            System.Console.WriteLine("name is: " + name);
            System.Console.WriteLine("age is: " + age);
            System.Console.WriteLine("roll_no is: " + rollno);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.show("Shreya", 22, 45);
            s.display();
            Console.WriteLine("---------------------------------------------");
            s.show("Mayuri", 21, 65);
            s.display();
            Console.ReadLine();
        }
    }
}
