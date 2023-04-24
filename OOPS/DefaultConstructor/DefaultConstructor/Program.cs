using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructor
{
    class student
    {
        int rno;
        string name;

        //creating a constructor
        public student() 
        {
            rno = 117;
            name = "Manchurian";
        }

        public void dataDisplay()
        {
            Console.WriteLine("your roll no is : " + rno);
            Console.WriteLine("your name is : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();  //it will call constructor
            stud1.dataDisplay();
            Console.ReadKey();
        }
    }
}
