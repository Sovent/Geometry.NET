using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.NET.Tests
{
	[TestClass]
    public class CircleTests
    {
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void ConstructCircleWithNegativeRadius_ThrowsArgumentException()
		{
			var negativeRadius = -10.0;

			new Circle(negativeRadius);
		}

		[TestMethod]
		public void ConstructCircleWithPositiveRadius_RadiusIsValidValue()
		{
			var positiveRadius = 5.3;
			var circle = new Circle(positiveRadius);

			var actualRadius = circle.Radius;

			Assert.AreEqual(positiveRadius, actualRadius);
		}

		[TestMethod]
		public void CalculateCircleArea_ReturnsCorrectValue()
		{
			var radius = 10;
			var expectedArea = 314.159265;
			var epsilon = 0.000001;
			var circle = new Circle(radius);

			var actualArea = circle.Area;
			var deviation = Math.Abs(expectedArea - actualArea);

			Assert.IsTrue(deviation < epsilon);
		}

		[TestMethod]
		public void CalculateCirclePerimeter_ReturnsCorrectValue()
		{
			var radius = 3.5;
			var expectedPerimeter = 21.9911486;
			var epsilon = 0.000001;
			var circle = new Circle(radius);

			var actualPerimeter = circle.Perimeter;
			var deviation = Math.Abs(expectedPerimeter - actualPerimeter);

			Assert.IsTrue(deviation < epsilon);
		}
    }
}
