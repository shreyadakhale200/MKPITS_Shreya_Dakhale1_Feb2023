using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiveToTwentyFiveDo_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            do
            {
                Console.WriteLine(i);
                i++;
            }while (25 >= i);
            Console.ReadKey();
        }
    }
}
