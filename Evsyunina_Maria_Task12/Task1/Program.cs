using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\79521\source\repos\Evsyunina_Maria_Task12\disposable_task_file.txt";
			string[] strings = File.ReadAllLines(path);
			int[] numbers = new int[strings.Length];
			for (int i=0; i<strings.Length; i++)
			{
				numbers[i] = Int32.Parse(strings[i]);
				numbers[i] = numbers[i] * numbers[i];
				strings[i] = numbers[i].ToString();
			}
			File.WriteAllLines(path, strings);
		}
	}
}
