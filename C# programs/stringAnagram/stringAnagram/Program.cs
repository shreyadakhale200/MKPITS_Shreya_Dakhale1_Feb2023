//Write a C# method that takes two strings as parameters and returns true if they are anagrams, false otherwise.

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "heater";
            string str1 = "reheat";
            bool s = Anagram(str, str1);
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static bool Anagram(string str,string str1)
        {
            char[] ch1 = str.ToLower().ToCharArray();
            char[] ch2 = str1.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val = new string(ch1);
            string val1 = new string(ch2);
            Console.WriteLine(val);
            Console.WriteLine(val1);
            if (val == val1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
