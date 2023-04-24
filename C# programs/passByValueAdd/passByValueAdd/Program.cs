//Write a C# method that takes two integers as parameters and returns their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace passByValueAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("Enter a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b :");
            b = int.Parse(Console.ReadLine());
            sum = Add(a,b);
            Console.WriteLine( a + " + " + b + " = " + sum);
            Console.ReadKey();
        }
        static int Add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
