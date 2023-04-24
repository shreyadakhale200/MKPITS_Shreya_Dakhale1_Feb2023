using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueAndBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                continue;   //will skip remaing statement and go for next iteration

                int j = 1;
                Console.WriteLine(j);
                break;      //will come out of the loop
            }Console.WriteLine("out of the loop");
            Console.ReadKey();
        }
    }
}
