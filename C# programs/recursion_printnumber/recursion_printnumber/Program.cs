using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_printnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            myfunc(x);
            Console.ReadKey();
        }
        
        static void myfunc(int x)
        {
            if (x >0)
            {
                Console.WriteLine(x);
                myfunc(x - 1);  // recursion
            }
        }
    }

}
