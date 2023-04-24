using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDataType
{
	internal class Program
	{
		static void Main(string[] args)
		{
			float b1;
			Console.WriteLine("enter float number : ");
			b1 = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("float entered = " + b1);
			Console.ReadKey();
			// 9.99 or 3.14515
		}
	}
}
