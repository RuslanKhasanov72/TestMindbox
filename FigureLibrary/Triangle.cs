﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
	public class Triangle:Figure
	{
		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 || sideB <= 0 || sideC <= 0)
				throw new ArgumentException("Sides must be greater than zero.");

			if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
				throw new ArgumentException("The sum of any two sides must be greater than the third side.");

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public override double CalculateArea()
		{
			double s = (SideA + SideB + SideC) / 2;
			return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
		}

		// Проверка, является ли треугольник прямоугольным
		public bool IsRightTriangle()
		{
			double[] sides = { SideA, SideB, SideC };
			Array.Sort(sides);
			return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
		}
	}
}
