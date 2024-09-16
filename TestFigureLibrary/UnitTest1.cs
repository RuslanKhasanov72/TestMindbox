using FigureLibrary;

namespace TestFigureLibrary
{
	public class UnitTest1
	{
		[Fact]
		public void CircleArea_CorrectRadius_ReturnsCorrectArea()
		{
			var circle = new Circle(5);
			double expectedArea = Math.PI * 25;
			Assert.Equal(expectedArea, circle.CalculateArea(), 5);
		}

		[Fact]
		public void TriangleArea_ValidSides_ReturnsCorrectArea()
		{
			var triangle = new Triangle(3, 4, 5);
			double expectedArea = 6;
			Assert.Equal(expectedArea, triangle.CalculateArea(), 5);
		}

		[Fact]
		public void Triangle_IsRightTriangle_ReturnsTrue()
		{
			var triangle = new Triangle(3, 4, 5);
			Assert.True(triangle.IsRightTriangle());
		}

		[Fact]
		public void Triangle_IsNotRightTriangle_ReturnsFalse()
		{
			var triangle = new Triangle(6, 4, 3);
			Assert.False(triangle.IsRightTriangle());
		}

		[Fact]
		public void ShapeHelper_GetArea_Circle_ReturnsCorrectArea()
		{
			IFigure circle = new Circle(7);
			double expectedArea = Math.PI * 49;
			Assert.Equal(expectedArea, FigureHelper.GetArea(circle), 5);
		}

		[Fact]
		public void ShapeHelper_GetArea_Triangle_ReturnsCorrectArea()
		{
			IFigure triangle = new Triangle(5, 12, 13);
			double expectedArea = 30;
			Assert.Equal(expectedArea, FigureHelper.GetArea(triangle), 5);
		}
	}
}