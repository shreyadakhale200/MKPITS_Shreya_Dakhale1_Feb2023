//Write a C# method that takes a decimal as a parameter and returns the integer portion of the decimal.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimalIntegerParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.WriteLine("Enter a number : ");
            number = float.Parse(Console.ReadLine());
            double num = Math.Floor(number);
            //Console.WriteLine(number);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
