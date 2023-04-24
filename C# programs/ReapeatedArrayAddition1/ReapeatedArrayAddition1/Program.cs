using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{ 
    internal class Program
    {
        class student
        {
            int roll_no;
            string name;

            ~student() 
            {
                Console.WriteLine("Obejct is destroyed");
            }


            public student()
            {
                roll_no = 117;
                name = "Mayna";
                Console.WriteLine("Object is created");
            }
            public void studentInfo(int roll_no, string name)
            {
                this.roll_no = roll_no;
                this.name = name;
            }
            public void DisplaystudentInfo()
            {
                Console.WriteLine("your roll no is : " + roll_no);
                Console.WriteLine("Enter name : " + name);
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Your Roll number : ");
                int roll_no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();

                student std1 = new student();
                std1.studentInfo(roll_no, name);
                std1.DisplaystudentInfo();
                Console.ReadKey();
            }
        }
    }
