using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Round
	{
		private double r; //поля класса
		public double _x { get; set; }
		public double _y { get; set; }

		public double Radius //достуа к радиусу
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

		public double GetLength() //расчет окружности
		{
			return 2 * r * Math.PI ;
		}

		public double GetArea() //расчет площади
		{
			return  Math.PI * r * r;
		}

		public Round(double x, double y, double r) //конструктор
		{
			_x = x;
			_y = y;
			this.r = r;
		}
	}
}
