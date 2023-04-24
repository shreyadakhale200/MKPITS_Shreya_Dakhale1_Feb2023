//wap to accept character from the user and display whether it is vowel or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrNotSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter a character : ");
            character = Convert.ToChar(Console.ReadLine());

            switch (character)
            {
                case 'a':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'A':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'e':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'E':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'i':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'I':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'o':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'O':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'u':
                    Console.WriteLine(character + " is a vowel");
                    break;

                case 'U':
                    Console.WriteLine(character + " is a vowel");
                    break;

                default:
                    Console.WriteLine(character + " is a consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}
