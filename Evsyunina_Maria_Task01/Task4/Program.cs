using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Task4

{

	class Program

	{

		static void Main(string[] args)

		{

			int RowCount = 0;

			while (RowCount == 0)

			{

				Console.WriteLine("Введите количеcтво строк");

				string InputConsole = Console.ReadLine();

				if (int.TryParse(InputConsole, out RowCount) == true && RowCount > 0)

				{

					Console.WriteLine($"Количество строк {RowCount}");

				}

				else

					Console.WriteLine("Некорректное значение!");

			}
			string FirstRow = "*";

			int TriangleBase = RowCount + 1;

			string CurrentRow = FirstRow.PadLeft(TriangleBase);

			Console.WriteLine(CurrentRow);

			for (int j = 1; j < RowCount; j++)
			{

				FirstRow = "*";

				TriangleBase = RowCount + 1;

				CurrentRow = FirstRow.PadLeft(TriangleBase);

				Console.WriteLine(CurrentRow);

				for (int i = 1; i < j + 1; i++)

				{

					string NextRow = CurrentRow.Remove(0, 1) + "**";

					CurrentRow = NextRow;

					Console.WriteLine(CurrentRow);

				}
			}

			Console.ReadKey();

		}

	}

}