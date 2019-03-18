using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			byte RowCount = 0;

			while (RowCount == 0)
			{
				Console.WriteLine("Введите количеcтво строк");

				string inputConsole = Console.ReadLine();

				if (byte.TryParse(inputConsole, out RowCount) == true && RowCount > 0)
				{
					Console.WriteLine($"Количество строк {RowCount}");

				}
				else
				{
					Console.WriteLine("Некорректное значение!");
				}
			}
			string CurrentRow = "";

			for (int i = 0; i < RowCount; i++)
			{
				CurrentRow = CurrentRow + "*";

				Console.WriteLine(CurrentRow);
			}
			Console.ReadKey();
		}
	}
}
