using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ClassUserInput
{
    class student
    {
        int rno;
        string name;
        int age;

        public void getData(int r, string n, int a)
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
            student s1 = new student();
            Console.WriteLine("Enter roll no : ");
            int rno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            s1.getData(rno,name,age);
            s1.displayData();
            Console.ReadKey();

        }
    }
}
