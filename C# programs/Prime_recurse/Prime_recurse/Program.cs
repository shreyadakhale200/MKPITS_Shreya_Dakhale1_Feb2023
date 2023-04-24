using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 2;
            int number;
            Console.WriteLine("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            int prime = Primefunc(number, number - 1);    // (2,1)
            if (prime == 1)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is a composite number ");
            }
            Console.ReadKey();
        }
        static int Primefunc(int number, int i)  //(2, 1)
        {
            if (i == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                if (number % i == 0)             
                {
                    return 0;
                }
                else
                {
                    return Primefunc(number, i - 1);     
                    //calculate, no of loop/ storing     
                }
            }
        }
    }
}

// 9,8
//  ____________
// |   return 1 |
// |    9,2     |
// |    9,3     |   return 1
// |    9,4     |   return 0
// |    9,5     |   return 0
// |    9,6     |   return 0
// |    9,7     |   return 0
// |    9,8     |   return 0
// |____________|
