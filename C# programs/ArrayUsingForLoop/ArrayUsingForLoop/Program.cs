using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUsingForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'e', 'i', 'o', 'u' };
            for(int i=0;i<arr.Length;i++) 
            {
                Console.WriteLine(arr[i]);
            }Console.ReadKey();
        }
    }
}
