using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	abstract class Figure
	{
		public abstract void Draw();

		static int counter = 0;

		public Figure()
		{
			counter++;
		}

		public static int Counter
		{
			get
			{
				return counter;
			}
		}
	}


	class Line : Figure
	{
		protected double coordinate11, coordinate12;
		protected double coordinate21, coordinate22;


		public Line(double coordinate11, double coordinate12, double coordinate21, double coordinate22) : base()
		{
			this.coordinate11 = coordinate11;
			this.coordinate12 = coordinate12;
			this.coordinate21 = coordinate21;
			this.coordinate22 = coordinate22;
		}

		public override void Draw()
		{
			Console.WriteLine("Это линия, которая начинается в точке ({0},{1}) и заканчивается в точке ({2},{3})", coordinate11, coordinate12, coordinate21, coordinate22);
		}
	}

	class Rectangle : Figure
	{
		protected double width, height;
		protected double coordinate1, coordinate2;

		public Rectangle(double width, double height, double coordinate1, double coordinate2) : base()
			{
			this.width = width;
			this.height = height;
			this.coordinate1 = coordinate1;
			this.coordinate2 = coordinate2;
		}

		public override void Draw()
		{
			Console.WriteLine("Это прямоугольник со сторонами {0} и {1}, с центром ({2},{3})", width, height, coordinate1, coordinate2);
		}
	}

	class Triangle : Figure
	{
		protected double side1, side2, side3;
		protected double coordinate1, coordinate2;

		public Triangle(double side1, double side2, double side3, double coordinate1, double coordinate2) : base()
			{
			this.side1 = side1;
			this.side2 = side2;
			this.side3 = side3;
			this.coordinate1 = coordinate1;
			this.coordinate2 = coordinate2;
		}

		public override void Draw()
		{
			Console.WriteLine("Это треугольник со сторонами {0}, {1} и {2}, с центром ({3},{4})", side1, side2, side3, coordinate1, coordinate2);
		}
	}

	class Round : Figure
	{
		protected double radius;
		protected double coordinate1, coordinate2;

		public Round(double radius, double coordinate1, double coordinate2) : base()
			{
			this.radius = radius;
			this.coordinate1 = coordinate1;
			this.coordinate2 = coordinate2;
		}

		public override void Draw()
		{
			Console.WriteLine("Это круг с радиусом {0}, с центром ({1},{2})", radius, coordinate1, coordinate2);
		}
	}

	class Ring : Figure
	{
		protected double radius, innerRadius;
		protected double coordinate1, coordinate2;

		public Ring(double radius, double innerRadius, double coordinate1, double coordinate2) : base()
			{
			this.radius = radius;
			this.innerRadius = innerRadius;
			this.coordinate1 = coordinate1;
			this.coordinate2 = coordinate2;
		}

		public override void Draw()
		{
			Console.WriteLine("Это кольцо с внешним радиусом {0}, с внутренним радиусом {1}, с центром ({2},{3})", radius, innerRadius, coordinate1, coordinate2);
		}
	}

}
