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
			Figure[] figuresArray = new Figure[Figure.Counter];

			do
			{

				Console.WriteLine("Какую фигуру необходимо создать: 1 - линию, 2 - прямоугольник, 3 - треугольник, 4 - круг, 5 - кольцо?");

				switch (int.Parse(Console.ReadLine()))
				{
					case 1:
						Console.WriteLine("Введите параметры линии");
						//расписать подробнее

						double coordinate11 = double.Parse(Console.ReadLine());
						double coordinate12 = double.Parse(Console.ReadLine());
						double coordinate21 = double.Parse(Console.ReadLine());
						double coordinate22 = double.Parse(Console.ReadLine());

						figuresArray[Figure.Counter + 1] = new Line(coordinate11, coordinate12, coordinate11, coordinate12);
						figuresArray[Figure.Counter].Draw();
						break;

					case 2:
						Console.WriteLine("Введите параметры прямоугольника");
						//расписать подробнее

						double width  = double.Parse(Console.ReadLine());
						double height = double.Parse(Console.ReadLine());
						double coordinate1 = double.Parse(Console.ReadLine());
						double coordinate2 = double.Parse(Console.ReadLine());

						figuresArray[Figure.Counter + 1] = new Line(coordinate11, coordinate12, coordinate11, coordinate12);
						figuresArray[Figure.Counter].Draw();
						break;

				}

			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);


		}
	}
}

