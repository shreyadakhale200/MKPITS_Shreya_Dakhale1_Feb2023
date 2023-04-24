using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getLengthArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int i = arr.GetLength(0);
            int j = arr.Length;
            Console.WriteLine("GetLength : " + i);  //method
            Console.WriteLine("Length : " + j);     //property
            Console.ReadKey();
        }
    }
}
