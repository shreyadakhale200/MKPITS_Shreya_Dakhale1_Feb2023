//Program to search an element in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFoundinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 43, 65, 76, 98 };
            int num,counter=0;
            bool isFound = false;
            Console.WriteLine("Enter number to found in an array : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(counter=0; counter<arr.Length; counter++)
            {
                if (arr[counter] == num)
                {
                    isFound = true;
                    break;
                }
            }if (isFound == true)
            {
                Console.WriteLine(num + " is found in an araay at position arr[" + counter + "]");
            }
            else
            { 
                Console.WriteLine(num + " is not found");
            }
            Console.ReadKey();
        }
    }
}
