using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            arr[0] = "Shreya";
            arr[1] = "Shrey1";
            arr[2] = "Shrey2";
            arr[3] = "Shrey3";
            arr[4] = "Shrey4";
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }Console.ReadKey();
        }
    }
}
