using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oneToTenFORLOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
