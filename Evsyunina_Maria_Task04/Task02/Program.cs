using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
	class Round
	{
		private double r;
		public double _x { get; set; }
		public double _y { get; set; }

		public double Radius
		{
			get
			{
				return r;
			}
			set
			{
				if (value >= 0)
					r = value;
			}
		}

		public double GetLength()
		{
			return 2 * r * Math.PI ;
		}

		public double GetArea()
		{
			return  Math.PI * r * r;
		}

		public Round(double x, double y, double r)
		{
			_x = x;
			_y = y;
			this.r = r;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Round circle1 = new Round(5.6, 6.9, 8.1);
			Console.WriteLine($"Координаты круга {circle1._x}, {circle1._y}");
			Console.WriteLine($"Радиус круга {circle1.Radius}");
			Console.WriteLine($"Длина окружности {circle1.GetLength()}");
			Console.WriteLine($"Площадь круга {circle1.GetArea()}");
			Console.ReadKey();
		}
	}
}
