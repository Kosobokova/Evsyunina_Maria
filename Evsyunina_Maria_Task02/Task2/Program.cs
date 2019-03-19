using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Task2
{
    class Program
    {
		static void Main(string[] args)
        {
            var random1 = new Random();
            int n1 = random1.Next(1, 20);
            int n2 = random1.Next(1, 20);
            int n3 = random1.Next(1, 20);
            int[,,] array = new int[n1,n2,n3];

			ArrayFunction.ArrayElements(array);

			ArrayFunction.ArrayReplacement(array);

			Console.WriteLine("Элементы заменены");

			Console.ReadKey();
		 }
	}
}

