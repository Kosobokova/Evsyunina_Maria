using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			int RowCount = 0;

			while (RowCount == 0)
			{
				Console.WriteLine("Введите количеcтво строк");
				string inputConsole = Console.ReadLine();
				if (int.TryParse(inputConsole, out RowCount) == true && RowCount > 0)
				{
					Console.WriteLine($"Количество строк {RowCount }");

				}
				else
				{
					Console.WriteLine("Некорректное значение!");
				}
			}
			string FirstRow = "*";
			int RowLenght = RowCount + 1;
			string CurrentRow = FirstRow.PadLeft(RowLenght);

			Console.WriteLine(CurrentRow);

			for (int i = 1; i < RowCount; i++)
			{
				string NextRow = CurrentRow.Remove(0, 1) + "**";
				CurrentRow = NextRow;
				Console.WriteLine(CurrentRow);
			}
			Console.ReadKey();
		}
	}
}
