using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
	class Program
	{
		public static void ComparisonCultures()
		{
			int[] cultures = new int[2];

			for (int i = 0; i < cultures.Length; i++)
			{
				Console.WriteLine($"Введите номер {i + 1} культуры: 1 - ru, 2 - en, 3 - invariant");

				cultures[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine($"Выбраны культуры {cultures[0]} и {cultures[1]}");

			CultureInfo culture1 = new CultureInfo("ru-RU", false);

			CultureInfo culture2 = new CultureInfo("en-US", false);

			CultureInfo culture3 = CultureInfo.InvariantCulture;

			DateTime date1 = new DateTime(2008, 4, 10);

			double number1 = 1234567.89;

			if ((Array.IndexOf(cultures, 1) >= 0) && (Array.IndexOf(cultures, 2) >= 0))
			{
				Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Cultures", culture1.Name, culture2.Name);
				Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Date", date1.ToString("f", culture1), date1.ToString("f", culture2));
				Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Number", number1.ToString("n", culture1), number1.ToString("n", culture2));
			}
			else
			{
				if ((Array.IndexOf(cultures, 1) >= 0) && (Array.IndexOf(cultures, 3) >= 0))
				{
					Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Cultures", culture1.Name, culture3.Name);
					Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Date", date1.ToString("f", culture1), date1.ToString("f", culture3));
					Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Date", number1.ToString("n", culture1), number1.ToString("n", culture3));
				}
				else
				{
					if ((Array.IndexOf(cultures, 2) >= 0) && (Array.IndexOf(cultures, 3) >= 0))
					{
						Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Cultures", culture2.Name, culture3.Name);
						Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Date", date1.ToString("f", culture2), date1.ToString("f", culture3));
						Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Date", number1.ToString("n", culture2), number1.ToString("n", culture3));
					}
					else
					{
						Console.WriteLine("Введены некорректные культуры!");
					}
				}
			}

		}


					static void Main(string[] args)
		{
			ComparisonCultures();
			Console.ReadKey();
		}
	}
}
