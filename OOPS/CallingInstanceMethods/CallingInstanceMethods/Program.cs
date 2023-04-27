using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingInstanceMethods
{
    class Person
    {
        public string Name = "Shreya";  //fields having public access modifiers
        public int Age = 28;            //fields having public access modifiers 
        public void PersonInfo(int Age)
        {
            Console.WriteLine("Age : " +  Age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PersonInfo(25);     //Modifying objects by Calling Instance Methods
            Console.ReadKey();
        }
    }
}
