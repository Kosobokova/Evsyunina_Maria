using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "";
			StringBuilder sb = new StringBuilder();
			int N = 100000;

			Stopwatch stopWatch1 = new Stopwatch();

			stopWatch1.Start();

			for (int i = 0; i < N; i++)
			{
				str += "*";
			}

			stopWatch1.Stop();

			TimeSpan timeSpent1 = stopWatch1.Elapsed;

			Console.WriteLine(String.Format("{0}:{1}:{2}.{3}",
			timeSpent1.Hours, timeSpent1.Minutes, timeSpent1.Seconds,
			timeSpent1.Milliseconds));

			Stopwatch stopWatch2 = new Stopwatch();

			stopWatch2.Start();

			for (int i = 0; i < N; i++)
			{
				sb.Append("*");
			}

			stopWatch2.Stop();

			TimeSpan timeSpent2 = stopWatch2.Elapsed;

			Console.WriteLine(String.Format("{0}:{1}:{2}.{3}",
			timeSpent2.Hours, timeSpent2.Minutes, timeSpent2.Seconds,
			timeSpent2.Milliseconds));

			Console.ReadKey();

		}
	}
}
