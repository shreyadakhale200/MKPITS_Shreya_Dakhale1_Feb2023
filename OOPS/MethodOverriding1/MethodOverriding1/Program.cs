using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding1
{
    class classroomSeven
    {
        public int rollno;
        public string name;
        public int age;
         
        public void Geometry(int studentRollNo,string studentName,int studentAge)
        {
            rollno = studentRollNo;
            name = studentName;
            age = studentAge;
            Console.WriteLine("Roll no is " + studentRollNo);
            Console.WriteLine("Name is " + studentName);
            Console.WriteLine("Age is " + studentAge);
            Console.WriteLine("Geometry subject is learnt");
        }
    }
    class classroomEight:classroomSeven
    {
        public void Geometry(int studentRollNo,string studentName,int studentAge)
        {
            Console.WriteLine("Advanced Geometry is learnt");
            Console.WriteLine("Roll no is " + studentRollNo);
            Console.WriteLine("Name is " + studentName);
            Console.WriteLine("Age is " + studentAge);
            //base.Geometry(studentRollNo,studentName,studentAge);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            classroomEight C8 = new classroomEight();
            C8.Geometry(47, "Shreya", 22);
            Console.ReadLine();
        }
    }
}
