using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rec = Add_recursion(5, 3);
            Console.WriteLine(rec);
            Console.ReadKey();
        }

        static int Add_recursion(int x, int y)
        {
            if(y<=0)
            {
                return 1;
            }
            else
            {
                return x + Add_recursion(x, y-1);
            }
        }
    }
}
// _____________
// |  return 1  | 15+1 = 16
// |     5      | 10+5= 15
// |     5      | 5+5 = 10
// |     5      | 5 
// |____________|
