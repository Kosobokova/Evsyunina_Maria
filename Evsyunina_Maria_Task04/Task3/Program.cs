using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Triangle
	{
		private int _a; //первая сторонв
		private int _b; //вторая сторона
		private int _c; //третья сторона

		public int SideA //доступ к первой стороне
		{
			get
			{
				return _a;
			}
			set
			{
				if (value >= 0)
					_a = value;
			}
		}

		public int SideB // доступ ко второй стороне
		{
			get
			{
				return _b;
			}
			set
			{
				if (value >= 0)
					_b = value;
			}
		}

		public int SideC // доступ к третьей стороне
		{
			get
			{
				return _c;
			}
			set
			{
				if (value >= 0 && value < (_a + _b))
					_c = value;
			}
		}

		public int GetLength() //расчет периметра
		{
			return _a + _b +_c;
		}

		public double GetArea() // расчет площади
		{
			double p = (_a + _b + _c) / 2;
			var temp = p * (p - _a) * (p - _b) * (p - _c);
			return Math.Sqrt(temp);
		}

		public Triangle (int a, int b, int c) // конструктор
		{
			SideA = a;
			SideB = b;
			SideC = c;
		}

	}


	class Program
	{
		static void Main(string[] args)
		{
			Triangle triangle1 = new Triangle(4, 5, 6);
			Console.WriteLine($"Стороны треугольника {triangle1.SideA}, {triangle1.SideB}, {triangle1.SideC}");
			Console.WriteLine($"Периметр треугольника {triangle1.GetLength()}");
			Console.WriteLine($"Периметр треугольника {triangle1.GetArea()}");
			Console.ReadKey();
		}
	}
}
