using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            var random1 = new Random();
            int CountElements = random1.Next(1, 20);
            int[] array = new int[CountElements];

			ArrayFunction.ArrayElements(array);

			ArrayFunction.WriteElements(array);

			int sum = ArrayFunction.ArraySumPositive(array);

			Console.WriteLine($"Сумма неотрицательных элементов массива {sum}");

            Console.ReadKey();
        }
    }
}
