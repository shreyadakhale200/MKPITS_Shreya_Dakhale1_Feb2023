using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = myFunct(5, 3);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static int myFunct(int x,int y)
        {
            if(y<=0)
            {
                return 1;
            }
            else
            {
                return x * (myFunct(x,y-1));
             //calculate * storing the value/ No of loops
            }
        }
    }
}
// stack
// ___________
// |return 1 |
// | 5,(5,0) |
// | 5,(5,1) |
// | 5,(5,2) |
// |_________|
// 5*5*5*1 = 125;
// here x is for calculating cube and y is for number of loops
