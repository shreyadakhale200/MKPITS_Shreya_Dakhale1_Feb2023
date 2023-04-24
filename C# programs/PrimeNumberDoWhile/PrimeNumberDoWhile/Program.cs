using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2, counter = 0, num;
            Console.WriteLine("Enter a num : ");
            num = int.Parse(Console.ReadLine());
            do
            {
                if(num == 2)
                {
                    counter = 0;
                    break;
                }
                if(num%i== 0)
                {
                    counter++;
                    break;
                }
                i++;
            }while(num > i);
            if (num==0)
            {
                Console.WriteLine(num + " is neither prime nor composite");
            }
            else if(counter == 0)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a composite number");
            }
            Console.ReadKey();
        }
    }
}
