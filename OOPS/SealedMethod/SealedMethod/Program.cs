using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    class person
    {
        // int num; //private default field
        //public int num; //public field
        //private int num; //private field
        //protected int num; //protected field
        //internal int num; //internal field
        public virtual void display() // base class to be inherited
        {
            Console.WriteLine("hello from person class");   //message
        }
    }
    class student : person          //student child class inheriting parent person class
    {
        public sealed override void display()
        {
            Console.WriteLine("Hello from student class");
        }
    }

    class PartStudent : student
    {
       //public override void display()
       //{
            //'PartStudent.display()' cannot override inherited member 'student.display()' because it is sealed
       //}
       public void show()
        {
            Console.WriteLine("Hello from PartStudent");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PartStudent student = new PartStudent();
            student.display();
            student.show();
            Console.ReadKey();
        }
    }
}
