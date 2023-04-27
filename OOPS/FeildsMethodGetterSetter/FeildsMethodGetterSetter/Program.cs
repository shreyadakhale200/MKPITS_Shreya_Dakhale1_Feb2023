using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeildsMethodGetterSetter
{
    class Student
    {
    public int rno;
    public string name;
    public int age;
    public string gender;

        public int Rno { get;set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roll no : ");
            int Rno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender : ");
            string gender = Console.ReadLine();

            Student student = new Student();
            Console.WriteLine(Rno);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.ReadKey();
        }
    }
}
