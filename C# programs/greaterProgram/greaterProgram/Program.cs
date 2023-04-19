using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter number 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if(number1 > number2)
            {
                Console.WriteLine(number1 + " is greater than " + number2);
            }
            else
            {
                Console.WriteLine(number2 + " is greatert than " + number1);
            }
            Console.ReadKey();
        }
    }
}
