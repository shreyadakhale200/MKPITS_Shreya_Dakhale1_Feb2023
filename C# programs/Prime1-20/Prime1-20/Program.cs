using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 1, last = 20,counter=0,num=2;

            for(first=1;first<=last;first++)
            {
                for(num=2;num<first;num++)
                {
                    if(first%num==0)
                    {
                        counter++;
                        break;
                    }
                }
                if (num == 0)
                {
                    Console.WriteLine(first + " is nor prime neither composite");
                }
                else if (counter == 0)
                {
                    Console.WriteLine(first + " is a prime number");
                }
                else
                {
                    Console.WriteLine(first + " is a composite number");
                }
                counter = 0;
            }
            Console.ReadKey(); 
        }
    }
}
