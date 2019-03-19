using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку, не больше 100 символов");

			string input = Console.ReadLine();

			Console.WriteLine($"Введенная строка {input}");

			var newText = Regex.Replace(input, @"\p{P}", "");

			Console.WriteLine($"Строка без знаков препинания {newText}");

			string[] array = Regex.Split(newText, @"\s");

			int sum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				string temp = array[i];
				int countForSum = temp.Length;

				Console.WriteLine(array[i]);

				sum = sum + countForSum;
			}
			int averageLength = sum / array.Length;

			Console.WriteLine($"Средняя длина слова {averageLength}");

			Console.ReadKey();

		}
			
    }
}
