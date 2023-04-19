using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDataTypeProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			short b1;
			Console.WriteLine("Enter short number : ");
			b1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("short entered : " +  b1);
			Console.ReadKey();
			// -32,768 to 32,767
		}
	}
}
