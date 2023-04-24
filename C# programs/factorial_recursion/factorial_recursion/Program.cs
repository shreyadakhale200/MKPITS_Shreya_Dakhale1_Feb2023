using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number :");
            number = Convert.ToInt32(Console.ReadLine());
            int rec = Find_Factorial(number);
            Console.WriteLine("Factorial of " + number +  " is : " + rec);
            Console.ReadKey();
        }

        static int Find_Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else
            {
                return number * (Find_Factorial(number - 1));
                 // calculate * Storing number\ no of loops
            }
        }
    }
}

// |                |
// |   return 1     |
// |       1        | 24*1 = 24
// |       2        | 12*2 = 24
// |       3        | 4*3 = 12
// |       4        | 4
// |________________|
