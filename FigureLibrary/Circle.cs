using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
	public class Circle:Figure
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			if (radius <= 0)
				throw new ArgumentException("Radius must be greater than zero.");

			Radius = radius;
		}

		public override double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}
	}
}
