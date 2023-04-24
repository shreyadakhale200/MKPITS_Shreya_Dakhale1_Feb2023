//Write a C# method that takes an array of integers as a parameter and returns the sum of all the integers in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfIntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            ADDarr(arr);
            Console.ReadKey();
        }
        static void ADDarr(int[] arr)//no need for params
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum = i + sum;
            }Console.WriteLine(sum);
        }
    }
}
