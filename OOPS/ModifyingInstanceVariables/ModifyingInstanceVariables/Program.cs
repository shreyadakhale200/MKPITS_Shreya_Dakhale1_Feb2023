using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyingInstanceVariables
{
    class Student
    {
        public int rollNo = 34;    // fields having public access modifier
        public string Name = "Shreya";         // fields having public access modifier
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.rollNo = 54;    //Modifying Instance Variable
        }
    }
}
