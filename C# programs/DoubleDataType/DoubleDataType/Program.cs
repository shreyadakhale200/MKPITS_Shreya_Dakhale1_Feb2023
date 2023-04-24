using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDataType
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double b1;
			Console.WriteLine("Enter byte number ");
			b1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Double entered = " + b1);
			Console.ReadKey();
			//precision of about 15 digits
		}
	}
}
