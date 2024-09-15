using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
	public static class ShapeHelper
	{
		public static double GetArea(IFigure figure)
		{
			return figure.CalculateArea();
		}
	}
}
