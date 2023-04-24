using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123_12_1StarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* * *
            //* *
            //*
            int row,column;
            for(row=3; row >= 1; row--)
            {
                for(column=1; row >= column;column++)
                {
                    Console.Write("*" + " ");
                }Console.WriteLine();
            }Console.ReadKey();
        }
    }
}
