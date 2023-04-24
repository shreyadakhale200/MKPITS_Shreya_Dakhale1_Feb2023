using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number and check whether it is even or odd : ");
            number = Convert.ToInt32(Console.ReadLine());
            if(number % 2==0)
            {
                Console.WriteLine(number + " is an even number ");
            }
            else
            {
                Console.WriteLine(number + " is an odd number ");
            }
            Console.ReadKey();
        }
    }
}
