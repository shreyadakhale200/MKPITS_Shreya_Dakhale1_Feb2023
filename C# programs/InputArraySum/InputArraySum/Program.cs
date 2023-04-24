using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter arr : ");
            for(int i = 0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            AddArr(arr);
            Console.ReadKey();
        }
        static void AddArr(int[] arr)
        {
            int result = 0;
            for(int counter=0; counter<arr.Length; counter++)
            {
                result = result + arr[counter];
            }
            Console.WriteLine("addition="+result);
        }
    }
}
