using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateObject_inClass
{
    class student
    {
      public int rno;
      public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student mahima = new student();
            mahima.rno = 47;
            mahima.name = "Mahima";
            Console.WriteLine("roll no : " + mahima.rno);
            Console.WriteLine("name : " + mahima.name);
            Console.ReadKey();
        }
    }
}
