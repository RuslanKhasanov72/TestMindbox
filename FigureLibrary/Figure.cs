using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
	public abstract class Figure:IFigure
	{
		public abstract double CalculateArea();
	}
}
