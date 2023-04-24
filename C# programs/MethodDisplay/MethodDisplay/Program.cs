using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//method without parameters and no return value
namespace MethodDisplay
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling display method ");
            display();
            Console.ReadKey();
        }
        static void display()
        {
                Console.WriteLine("Hello World");
        }

    }
}
