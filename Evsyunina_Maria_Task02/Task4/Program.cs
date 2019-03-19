using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random1 = new Random();
            int n1 = random1.Next(1, 5);
            int n2 = random1.Next(1, 5);
            int[,] array = new int[n1, n2];
			for (int i = 0; i < n1; i++)

			ArrayFunction.ArrayElements(array);

			ArrayFunction.WriteElements(array);

			int sum = ArrayFunction.ArraySumEven(array);

            Console.WriteLine($"Сумма элементов на четных позициях {sum}");

            Console.ReadKey();
        }
    }
}
