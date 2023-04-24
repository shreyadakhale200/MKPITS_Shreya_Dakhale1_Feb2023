using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueLengthParamsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
            total = Add(3, 54, 76, 9, 2, 12);
            Console.WriteLine("total is = " + total);
            Console.ReadKey();
        }
        static int Add(params int[] val)
        {
            int counter = 0,total = 0;
            for(counter = 0; counter < val.Length;counter++)
            {
                total = total + val[counter];
            }
            return total;
        }
    }
}
