using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку, не больше 100 символов");

			string input = Console.ReadLine();

			var newText = Regex.Replace(input, @"\p{P}", "");

			string[] array = Regex.Split(newText, @"\s", RegexOptions.IgnoreCase);

			Dictionary<string, int> repeats = new Dictionary<string, int> ();

			var result = array.Distinct();

			

			foreach (string i in result)
			{
				int countMatches = 0;
				for (int j = 0; j < array.Length; j++)
				{
					if (i == array[j])
					{
						countMatches++;
					}
				}
				repeats.Add(i, countMatches);
			}

			foreach (KeyValuePair<string, int> keyValue in repeats)
			{
				Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
			}

			Console.ReadKey();

			var result1 = array
			 .Select(str => new { Name = str, Count = array.Count(s => s == str) })
			 .Distinct()
			 .ToDictionary(obj => obj.Name, obj => obj.Count);

			foreach (KeyValuePair<string, int> keyValue in result1)
			{
				Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
			}

			Console.ReadKey();

		}
	}
}
