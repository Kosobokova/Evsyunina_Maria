using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> list1 = new List<string>() { "a", "b", "c", "d", "e" };

			RemoveEachSecondItem(list1);

			Console.WriteLine(list1.Count);
			Console.WriteLine(list1[0]);

			LinkedList<string> list2 = new LinkedList<string>();

			list2.AddLast("a");
			list2.AddLast("b");
			list2.AddLast("c");
			list2.AddLast("d");
			list2.AddLast("e");

			RemoveEachSecondItem(list2);

			Console.WriteLine(list2.Count);
			Console.WriteLine(list2.First.Value);
			Console.ReadKey();
			}

		public static void RemoveEachSecondItem(List<string> list)
			{
				do
				{
					list.Add(list[0]);
					list.RemoveAt(0);
					list.RemoveAt(0);
				}
				while (list.Count != 1);
			}

			public static void RemoveEachSecondItem(LinkedList<string> list)
			{
				do
				{
					list.AddLast(list.First.Value);
					list.RemoveFirst();
					list.RemoveFirst();
				}
				while (list.Count != 1);

			}
		}
	}

