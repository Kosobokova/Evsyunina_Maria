using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Ring : Round
	{
		private double innerR; //поле Внутренний радиус
		private double ringArea;
		private double ringLength;

		public double InnerRadius //доступ ко внутреннему радиусу
		{
			get
			{
				return innerR;
			}
			set
			{
				if (value >= 0 && value < Radius)
					innerR = value;
			}
		}

		public double RingArea //свойство, позволяет узнать площадь кольца
		{
			get
			{
				return ringArea;
			}
			set
			{
				ringArea = Math.PI * Radius * Radius - Math.PI * InnerRadius * InnerRadius;
			}
		}

		public double RingLength //свойство, позволяет узнать суммарную длину внешней и внутреней границ кольца
		{
			get
			{
				return ringLength;
			}
			set
			{
				ringLength = 2 * Radius * Math.PI + 2 * InnerRadius * Math.PI;
			}
		}

		public Ring(double x, double y, double r, double innerR) : base(x, y, r)
		{
			InnerRadius = innerR;
		}
	}
}
