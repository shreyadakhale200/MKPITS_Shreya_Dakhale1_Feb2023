//Write a C# method that takes a double as a parameter and returns its square.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleParameterSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.WriteLine("Enter number : ");
            number = double.Parse(Console.ReadLine());
            Square(number);
            Console.ReadKey();
        }
        static void Square(double s1)
        {
            Console.WriteLine("Square of " + s1 + " = " + s1 * s1);
        }
    }
}
