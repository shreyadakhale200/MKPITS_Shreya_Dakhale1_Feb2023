//create a array to store 5 student name

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNameArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Studentname = new string[] { "Shreya", "Mahima", "Rupali", "Shreyaa", "Shreyab" };
            for(int student = 0;student < Studentname.Length;student++)
            {
                Console.WriteLine("Student " + (student+1) + " : " + Studentname[student]);
            }
            Console.ReadKey();
        }
    }
}
