//wap to print febonachi series 1,1,2,3,5,8,13.....

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonnaciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j =  1;
            Console.WriteLine(i + " ");
            Console.WriteLine(j);
            //print j
            for(int k=2;k<=8;k++)  //k = 2
            {
                //1,1,2,3,5,8,13....
                int sum = j + i;    //1 + 2 = 3
                i = j;
                j = sum;
                Console.WriteLine(j + " ");
            }Console.ReadKey();
        }
    }
}
