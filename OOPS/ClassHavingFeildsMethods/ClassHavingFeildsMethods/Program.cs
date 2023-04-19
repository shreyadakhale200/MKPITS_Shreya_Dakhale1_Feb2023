using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHavingFeildsMethods
{
    class student
    {
        int rno;
        string name;
        int age;
        string gender;
        public void getData()
        {
            rno = 57;
            name = "Shreya";
            age = 21;
            gender = "female";
        }
        public void displayData()
        {
            Console.WriteLine(rno);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            student s1 = new student();
            s1.getData();
            s1.displayData();
            Console.ReadKey();
        }
    }
}
