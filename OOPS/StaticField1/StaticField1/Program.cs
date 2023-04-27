using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticField1
{
    abstract class Batches
    {
        public static string PrincipalName = "Gati Sir";

        public abstract void Batch();
        public static void Owner()
        {
            Console.WriteLine("Owner of MKPITS is Ashish Sir");
        }
    }
    class Dotnet : Batches
    {
        public override void Batch()
        {
            string teacherName = "Khan sir";
            Console.WriteLine("Teacher of DotNet batch: " + teacherName);
            Console.WriteLine("Principal of DotNet batch : " + PrincipalName + "\n");
        }
    }
    class Java:Batches
    {
        public override void Batch()
        {
            string teacherName = "Nirmik sir";
            Console.WriteLine("Teacher of Java batch: " + teacherName);
            Console.WriteLine("Principal of Java batch : " + PrincipalName + "\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dotnet dotnet = new Dotnet();
            dotnet.Batch();
            Java java = new Java();
            java.Batch();
            Batches.Owner();
            Console.ReadKey();
        }
    }
}
