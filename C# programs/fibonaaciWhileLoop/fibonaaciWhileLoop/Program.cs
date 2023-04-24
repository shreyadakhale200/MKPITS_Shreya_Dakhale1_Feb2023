using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaaciWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1,k=2;
            Console.WriteLine(i);
            Console.WriteLine(j);
            while(k <= 8)
            {
                int sum = i + j;
                i = j;
                j = sum;
                Console.WriteLine(j);
                k++;
            }Console.ReadKey();
        }
    }
}
