using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getLength_2dArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3] { { 1,2,3},{4,5,6},{7,8,9} };
            int i = arr.GetLength(0);
            Console.WriteLine("getLength : " + i);
            Console.ReadKey();
        }
    }
}
