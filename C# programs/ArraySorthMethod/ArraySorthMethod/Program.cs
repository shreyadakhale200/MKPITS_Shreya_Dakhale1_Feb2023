using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorthMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 22, 32, 53, 54 };
            Array.Sort(num);
            for(int i=0; i<num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
