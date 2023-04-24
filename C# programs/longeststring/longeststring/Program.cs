//Write a C# method that takes an array of strings as a parameter and returns the longest string in the array.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace longeststring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Shreya", "Shival", "Ronav", "Prathmesh","Atharva" };
            Array.Sort(arr);
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
