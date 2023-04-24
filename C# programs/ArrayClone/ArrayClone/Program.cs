using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr  = { 1, 2, 3 ,54,87,45};
            int[] arr1 = (int[])arr.Clone();
            Console.Write("arr 1 : ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write( arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Cloned array : ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write( arr1[i] + " ");
            }Console.ReadKey();
        }
    }
}
