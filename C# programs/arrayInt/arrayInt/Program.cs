using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] {1,2,3};
            int[] arr1 = new int[4];
            arr1[0] = 32;
            arr1[1] = 3;
            arr1[2] = 2;
            arr1[3] = 54;
            Console.WriteLine("arr");
            foreach (int i in arr)
            {
                Console.Write( i + " ");
            }Console.WriteLine();
            Console.WriteLine("arr1");
            foreach (int i in arr1)
            {
                Console.Write( i + " ");
            }
            Console.ReadKey();
        }
    }
}
