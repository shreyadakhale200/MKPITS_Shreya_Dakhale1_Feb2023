using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlessClickedZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess;
      //Console.WriteLine("Enter a num : ");
      //guess = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter a num : ");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("hey welcome");
            } while (guess != 0);

            Console.WriteLine("bye");
            Console.ReadKey();

        }
    }
}
