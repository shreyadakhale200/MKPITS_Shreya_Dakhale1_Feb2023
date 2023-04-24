using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_NoOfDiffParam
{

    class student
    {
        int rollno;
        string name;

        //No of Parameters are different 
        public void getData(int rollno)
        {
            this.rollno = rollno;
            name = "Sarah";
        }
        public void getData(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Your roll no is : " +  rollno);
            Console.WriteLine("Your name is : " +  name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------student 1 Details-------------");
            student std1 = new student();
            std1.getData(32);
            std1.Display();

            Console.WriteLine("------------student 2 Details-------------");
            student std2 = new student();
            std2.getData(32,"Shreya");
            std2.Display();
            Console.ReadKey();
        }
    }
}
