using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHavingMethodsFeilds_Constructor
{
    class Student
    {
    public int rno;
    public string name;
    public int age;
    public string gender;

    public Student(int rno, string name, int age, string gender)
    {
        this.rno = rno;
        this.name = name;
        this.age = age;
        this.gender = gender;
    }
      
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

            Student student = new Student(Rno,name,age,gender);
            Console.WriteLine(Rno);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine("Destructor");
            Console.ReadKey();
        }
    }
}
