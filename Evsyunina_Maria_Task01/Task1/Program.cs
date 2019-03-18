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
            uint RectangleLength = 0;
            uint RectangleWidht = 0;
            while (RectangleLength == 0)
            {
                Console.WriteLine("Введите длину прямоугольника");
                string InputLenght = Console.ReadLine();
                bool CorrectInputLenght = uint.TryParse(InputLenght, out RectangleLength);
				if (CorrectInputLenght == true && RectangleLength > 0)
				{
					Console.WriteLine($"Длина прямоугольника {RectangleLength}");

				}
				else
				{
					Console.WriteLine("Некорректное значение!");
				}
            }
            while (RectangleWidht == 0)
            {
                Console.WriteLine("Введите ширину прямоугольника");
                string InputWidth = Console.ReadLine();
                bool CorrectInputWidth = uint.TryParse(InputWidth, out RectangleWidht);
                if (CorrectInputWidth == true && RectangleWidht > 0)
                    Console.WriteLine($"Ширина прямоугольника {RectangleWidht}");
                else
                    Console.WriteLine("Некорректное значение!");
            }
            uint RectangleArea = RectangleLength * RectangleWidht;
            Console.WriteLine($"Площадь прямоугольника {RectangleArea}");
            Console.ReadKey();
        }
    }
}
