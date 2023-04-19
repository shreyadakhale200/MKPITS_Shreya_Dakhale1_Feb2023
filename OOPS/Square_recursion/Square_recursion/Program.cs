using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number to calculate square : ");
            number = Convert.ToInt32(Console.ReadLine());
            int loop = 2;

            //int square = Squarecalculate(number, loop);
            int square = Squarecalculate(number, loop);
            Console.WriteLine(square);
            Console.ReadKey();
        }

        static int Squarecalculate(int number, int loop)
        {
            if (loop == 0)
            {
                return 1;
            }
            else
            {
                return number * Squarecalculate(number, loop - 1);
            }
        }
    }
}
