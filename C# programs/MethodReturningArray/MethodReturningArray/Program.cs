using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturningArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = myArray();
            foreach(int i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        static int[] myArray()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            return myArray;
        }
    }
}
