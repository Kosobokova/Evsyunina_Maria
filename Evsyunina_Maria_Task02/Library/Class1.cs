using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ArrayFunction
    {
		public static void ArrayElements(params int[] array)
		{
			var random2 = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random2.Next(1, 100);
			}
		}

		public static void ArrayElements(int[,] array)
		{
			var random1 = new Random();

			for (int i = 0; i < array.GetUpperBound(0)+1; i++)
			{
				for (int j = 0; j < array.GetUpperBound(1)+1; j++)
				{
						array[i, j] = random1.Next(1, 100);
				}
			}
		}

		public static void ArrayElements(int[,,] array)
		{
			var random1 = new Random();

			for (int i = 0; i < array.GetUpperBound(0)+1; i++)
			{
				for (int j = 0; j < array.GetUpperBound(1)+1; j++)
				{
					for (int k = 0; k < array.GetUpperBound(2)+1; k++)
					{
						array[i, j, k] = random1.Next(1, 100);
					}
				}
			}
		}

		public static void WriteElements(params int[] array)
		{
			Console.WriteLine();
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");
			}
		}

		public static void WriteElements(int[,] array)
		{
			Console.WriteLine();
			for (int i = 0; i < array.GetUpperBound(0)+1; i++)
			{
				Console.WriteLine();
				for (int j = 0; j < array.GetUpperBound(1)+1; j++)
				{
					Console.Write($"{array[i,j]} ");
				}
			}
		}

		public static void SortElements(params int[] array)
		{
			int temp;
			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] > array[j])
					{
						temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}
		}

		public static void ArrayReplacement(int[,,] array)
		{
			for (int i = 0; i < array.GetUpperBound(0)+1; i++)
			{
				for (int j = 0; j < array.GetUpperBound(1)+1; j++)
				{
					for (int k = 0; k < array.GetUpperBound(2)+1; k++)
					{
						if (array[i, j, k] > 0)
						{ array[i, j, k] = 0; }
					}
				}
			}
		}

		public static int ArraySumPositive(params int[] array)
		{
			int sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > 0)
				{ sum = sum + array[i]; }
			}
			return sum;
		}

		public static int ArraySumEven(int[,] array)
		{
			int sum = 0;
			for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
			{
				for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
				{
					int a = (i + j) % 2;
					if (a == 0) { sum = sum + array[i, j]; }
				}
			}
			return sum;
		}
	}
}
