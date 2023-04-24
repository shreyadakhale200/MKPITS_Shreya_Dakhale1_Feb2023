using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime1_20WhileLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2, counter = 0, first = 1, last = 20;
            while (first <= last)
            {
                while (num < first)
                {
                    if(first%num==0)
                    {
                        counter++;
                        break;
                    }
                    num++;
                }
                if(num == 0)
                {
                    Console.WriteLine(first + " is not prime nor composite");
                }
                else if(counter == 0)
                {
                    Console.WriteLine(first + " is a prime number");
                }
                else 
                {
                    Console.WriteLine(first + " is a composite number");
                }
                num = 2;
                counter = 0;
                first++;
            }
            Console.ReadKey();
        }
    }
}
