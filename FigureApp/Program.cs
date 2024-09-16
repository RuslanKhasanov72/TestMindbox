using System;
using FigureLibrary;

namespace FigureApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var circle = new Circle(5);
			double area = FigureHelper.GetArea(circle);
			Console.WriteLine($"Area of the circle: {area}");

			var triangle = new Triangle(5,6,7);
			area = FigureHelper.GetArea(triangle);
			Console.WriteLine($"Area of the triangle: {area}. Is right triangle: {triangle.IsRightTriangle().ToString()}");
		}
	}
}