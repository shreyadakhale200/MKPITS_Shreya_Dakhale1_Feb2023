using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UShortDataTypeProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ushort b1;
			Console.WriteLine("enter ushort number : ");
			b1 = Convert.ToUInt16(Console.ReadLine());
			Console.WriteLine("ushort entered = " + b1);
			Console.ReadKey();
			//ushort 0 to 65,535 Unsigned 16 - bit integer
		}
	}
}
