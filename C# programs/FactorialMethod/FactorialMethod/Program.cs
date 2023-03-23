//Create a method factorial with one parameter to calculate factorial of a number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter a number to calculate factorial : ");
            n1 = int.Parse(Console.ReadLine());
            int Factorial = factorial(n1);
            Console.WriteLine("Factorial of " + n1 + " is = " +  Factorial);
            Console.ReadKey();
        }

        static int factorial(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num;i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}
