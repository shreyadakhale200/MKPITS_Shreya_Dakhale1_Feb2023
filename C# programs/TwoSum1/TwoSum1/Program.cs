using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int i = 0,j=0;
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        Console.Write(i);
                        if (i == 0)
                        {
                            Console.Write(",");
                        }
                        else
                        {
                            Console.Write(",");
                        }
                        Console.Write(j);
                    }
                }
            }
            Console.Write("]");
            Console.ReadKey();
        }

    }
}
