using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int i = Array.IndexOf(arr, 4);
            Console.WriteLine("Index is : " + i);
            Console.ReadKey();
        }
    }
}
