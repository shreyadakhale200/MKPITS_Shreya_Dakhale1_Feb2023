using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingandOverridingMethodUsingConstructor
{
    class SevenSTD
    {
        public string SubjectName = "Geometry";
        public static int Geometry;

        public SevenSTD()
        {
            Geometry = 78;
        }
        public virtual void SubjectMarks()
        {
            Console.WriteLine("Geometry Marks : " + Geometry);
        }
    }
    class EightSTD : SevenSTD
    {
        public EightSTD()
        {
            Geometry = 99;
        }
        public override void SubjectMarks()
        {
            Console.WriteLine("Geometry Marks : " + Geometry);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SevenSTD std = null;
            if (SevenSTD.Geometry == 78)
            {
                std = new SevenSTD();
            }
            else
            {
                std = new EightSTD();
            }
            std.SubjectMarks();
            Console.ReadKey();
        }
    }
}
