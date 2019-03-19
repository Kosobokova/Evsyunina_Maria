using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Task1
{
    class Program

    {
		static void Main(string[] args)
        {
            var random1 = new Random();

            int countElements = random1.Next(1, 20);

            int[] array = new int[countElements];

			ArrayFunction.ArrayElements(array);

			ArrayFunction.WriteElements(array);

			ArrayFunction.SortElements(array);

			Console.WriteLine("\n Отсортированный массив");

			ArrayFunction.WriteElements(array);

			Console.WriteLine($"\n Минимальный элемент массива {array[0]}");

			Console.WriteLine($"\n Максимальный элемент массива {array[array.Length - 1]}");

			Console.ReadKey();
        }
    }
}
