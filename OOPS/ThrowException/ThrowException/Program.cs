using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age;
            try
            {
            Console.WriteLine("Enter age : ");
            Age = Convert.ToInt32(Console.ReadLine());
                if(Age <= 0 || Age > 100)
                {
                    throw new Exception("Enter proper age");
                }
                else
                {
                    Console.WriteLine("Your age is : " + Age);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
