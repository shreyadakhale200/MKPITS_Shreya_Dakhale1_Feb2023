using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("Your age is " + age + " you are eligible to vote ");
            }
            else
            {
                Console.WriteLine("Your age is " + age + " you are not eligible to vote ");
            }
            Console.ReadKey();
        }
    }
}
