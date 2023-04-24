// Write a program to accept a name from the user and print it along with hello 

using System;
namespace NameUserInput
{
    class Program
    {
        static void Main()
        {
            string name;    //declaring name
            Console.WriteLine("Enter  your name dear : "); 
            name = Console.ReadLine();
            Console.WriteLine("Hello mr/miss " + name);
            Console.ReadKey();
        }
    }
}
