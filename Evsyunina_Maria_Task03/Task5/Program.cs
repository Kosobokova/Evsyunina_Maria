using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку, не больше 100 символов");

			string input = Console.ReadLine();

			Console.WriteLine($"Введенная строка {input}");

			var newText = Regex.Replace(input, @"<", "_");

			var newText1 = Regex.Replace(newText, @">", "_");

			Console.WriteLine($"Строка с заменнеными тэгами {newText1}");

			Console.ReadKey();
		}
	}
}
