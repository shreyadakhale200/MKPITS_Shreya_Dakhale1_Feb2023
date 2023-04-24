using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[ 6 ];
            arr[0] = 1;
            arr[1] = 13;
            arr[2] = 121;
            arr[3] = 34;
            arr[4] = 12;
            arr[5] = 65;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }Console.ReadKey();
        }
    }
}
