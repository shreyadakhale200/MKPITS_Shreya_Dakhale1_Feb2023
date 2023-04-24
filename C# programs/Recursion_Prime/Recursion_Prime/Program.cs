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
            int x = 9;
            int prime = Primefunc(x, x / 2);    // (6,6/2 = 3)
            if(prime == 1)
            {
                Console.WriteLine(x + " is a prime number");
            }
            else
            {
                Console.WriteLine(x + " is not a prime number ");
            }
            Console.ReadKey();
        }
        static int Primefunc(int x, int i)  //(5, 2)
        {
            if(i==1  || x==2)
            {
                return 1;
            }
            else
            {
                if(x % i == 0)
                {
                    return 0;
                }
                else
                {
                    return Primefunc(x, i-1);
                           //calculate, no of loop/ storing     
                }
            }
        }
    }
}
