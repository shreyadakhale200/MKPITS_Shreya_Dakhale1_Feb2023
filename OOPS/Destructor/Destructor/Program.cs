using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{

    class student
    {
        int rno;
        string name;
        ~student()
        {
            Console.WriteLine("Object Destroyed");
        }
        public student()
        {
            Console.WriteLine("object created");
            rno = 32;
            name = "Shreya";


        }
        public void getData(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void Displaydata()
        {
            Console.WriteLine("your roll number is : " + rno);
            Console.WriteLine("your name is :" + name);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter your roll no : ");
            int roll_no;

            // Console.WriteLine("Enter name : ");
            string name;
           

            student std1 = new student();
            std1.getData(23, "shreya");
            std1.Displaydata();
            //std1 = null;
            Console.ReadKey();
        }
    }
}

/*It's important to note that the destructor in C# is not the same as the destructor in C++. In C#, the destructor is automatically
 * called by the garbage collector when the object is no longer needed, whereas in C++, the destructor must be called explicitly.*/
