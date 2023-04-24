//wap to accept character from the user and display whether it is vowel or not.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOrVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter a Character : ");
            character = Convert.ToChar(Console.ReadLine());
            if(character =='a' ||  character == 'A' || character == 'e' || character == 'E' || character == 'i' || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
            {
                Console.WriteLine(character + " is a vowel");
            }
            else
            { 
                Console.WriteLine(character + " is a consonant");
            }
            Console.ReadKey();
        }
    }
}
