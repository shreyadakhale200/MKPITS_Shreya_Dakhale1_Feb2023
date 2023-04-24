using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDataType
{
	internal class Program
	{
		static void Main(string[] args)
		{
			long b1;
			Console.WriteLine("Enter long number ");
			b1 = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("long Entered = " + b1);
			Console.ReadKey();
			// -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
		}
	}
}
