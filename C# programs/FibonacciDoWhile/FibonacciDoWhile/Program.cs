using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 1;
            int k = 2;
            Console.Write(i + " ");
            Console.Write(j + " ");
            do
            {
                int sum = i + j;
                i = j;
                j = sum;
                Console.Write(j + " ");
                k++;
            }while (k <= 8);
            Console.ReadKey();
        }
    }
}
