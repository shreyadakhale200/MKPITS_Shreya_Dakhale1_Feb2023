using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToSByteProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			sbyte b1;
			Console.WriteLine("Enter a byte ");
			b1 = Convert.ToSByte(Console.ReadLine());
			Console.WriteLine("sbyte entered : " + b1);
			Console.ReadKey();
			// -128 to 127
		}
	}
}

