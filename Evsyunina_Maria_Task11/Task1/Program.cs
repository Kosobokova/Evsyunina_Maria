using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int result1 = Class1.TaskFactorial(5);
			int result2 = Class1.TaskToAPower(2,3);

			Console.WriteLine(result1);
			Console.WriteLine(result2);
			Console.ReadKey();
		}
	}
}
