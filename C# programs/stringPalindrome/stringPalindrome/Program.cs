//Write a C# method that takes a string as a parameter and returns true if the string is a palindrome, false otherwise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string : ");
            str = Console.ReadLine();
            //Console.WriteLine(str[0]);
            //foreach (char c in str)
            //Console.WriteLine(c);
            StringPalindrome(str);
            Console.ReadKey();
        }
        static void StringPalindrome(string str)
        {
            char[] CharArray = str.ToCharArray();
            string reversedString = String.Empty;
            for(int i = CharArray.Length - 1; i >= 0; i--) 
            {
                reversedString += CharArray[i];
            }
            if(reversedString == str)
            {
                Console.WriteLine(str + " is palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not palindrome");
            }
            
        }
    }
}
