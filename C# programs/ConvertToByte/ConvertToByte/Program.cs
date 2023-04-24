using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToByte
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte b1;
			Console.WriteLine("Enter byte  : ");
			b1 = Convert.ToByte(Console.ReadLine());
			Console.WriteLine("Byte Entered = " + b1);
			Console.ReadKey();
			// 0 to -255
		}
	}
}
