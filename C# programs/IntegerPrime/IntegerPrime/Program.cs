//Write a C# method that takes an integer as a parameter and returns true if the integer is prime, false otherwise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter  a number : ");
            number = int.Parse(Console.ReadLine());
            Prime(number);
            Console.ReadKey();
        }
        static void Prime(int number)
        {
            int counter = 0;
            for(int divisibleBy = 2; divisibleBy < number;  divisibleBy++)
            {
                if(number%divisibleBy == 0)
                {
                    counter++;
                    break;
               }
            }
            if(number == 0)
            {
                Console.WriteLine(number + " is neither prime nor composite");
            }
            else if(counter == 0)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number");
            }
        }
    }
}
