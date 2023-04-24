using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHavingFeildMethods
{
    class Student
    {
    public int rno;
    public string name;
    public int age;
    public string gender;

        public void getData(int rno, string name, int age, string gender)
        {
            this.rno = rno;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public void displayData()
        {
            Console.WriteLine("Roll no of student : " + this.rno);
            Console.WriteLine("Name of student : " + this.name);
            Console.WriteLine("Age of student : " + this.age);
            Console.WriteLine("Gender of student : " + this.gender);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roll no : ");
            int Roll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender : ");
            string gender = Console.ReadLine();

            Student student = new Student();
            student.getData(Roll_no,name,age,gender);
            student.displayData();
            Console.ReadKey();
        }
    }
}
