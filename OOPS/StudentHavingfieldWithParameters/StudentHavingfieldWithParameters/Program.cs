using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHavingfieldWithParameters
{
    class student
    {
        int rno;
        string name;
        int age;

        public void getData(int r, string n,int a)
        {
            rno = r;
            name = n;
            age = a;
        }

        public void displayData() 
        {
            Console.WriteLine(rno);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student st1 = new student();
            st1.getData(45,"Shreya",21);
            st1.displayData();
            Console.ReadKey();
        }
    }
}
