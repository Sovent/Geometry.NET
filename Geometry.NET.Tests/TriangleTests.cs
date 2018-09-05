using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.NET.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
		[ExpectedException(typeof(ArgumentException))]
        public void ConstructInvalidTriangle_ThrowsArgumentException()
        {
			var aSide = 1;
			var bSide = 2;
			var cSide = 4;

			new Triangle(aSide, bSide, cSide);
        }

		[TestMethod]
		public void ConstructValidTriangle_PropertiesAreProperlyMapped()
		{
			var aSide = 2;
			var bSide = 3;
			var cSide = 4;
			var triangle = new Triangle(aSide, bSide, cSide);

			var actualASide = triangle.ASideLength;
			var actualBSide = triangle.BSideLength;
			var actualCSide = triangle.CSideLength;

			Assert.AreEqual(aSide, actualASide);
			Assert.AreEqual(bSide, actualBSide);
			Assert.AreEqual(cSide, actualCSide);
		}

		[TestMethod]
		public void CallIsValidTriangleOnInvalidArguments_ReturnsFalse()
		{
			var aSide = 10.7;
			var bSide = 3;
			var cSide = 7.5;

			var isValid = Triangle.IsValidTriangle(aSide, bSide, cSide);

			Assert.IsFalse(isValid);
		}

		[TestMethod]
		public void CallIsValidTriangleOnValidArguments_ReturnsTrue()
		{
			var aSide = 11;
			var bSide = 32;
			var cSide = 25;

			var isValid = Triangle.IsValidTriangle(aSide, bSide, cSide);

			Assert.IsTrue(isValid);
		}

		[TestMethod]
		public void CallIsValidTriangleWithNegativeArgument_ReturnsFalse()
		{
			var aSide = -1;
			var bSide = 7;
			var cSide = 4;

			var isValid = Triangle.IsValidTriangle(aSide, bSide, cSide);

			Assert.IsFalse(isValid);
		}

		[TestMethod]
		public void CalculateTrianglePerimeter_ReturnsValidValue()
		{
			var aSide = 4;
			var bSide = 6;
			var cSide = 7;
			var expectedPerimeter = 17;
			var triangle = new Triangle(aSide, bSide, cSide);

			var actualPerimeter = triangle.Perimeter;

			Assert.AreEqual(expectedPerimeter, actualPerimeter);
		}

		[TestMethod]
		public void CalculateTriangleArea_ReturnsValidValue()
		{
			var aSide = 12.3;
			var bSide = 8.14;
			var cSide = 9.2;
			var expectedArea = 37.443872;
			var epsilon = 0.000001;
			var triangle = new Triangle(aSide, bSide, cSide);

			var actualArea = triangle.Area;
			var deviation = Math.Abs(expectedArea - actualArea);

			Assert.IsTrue(deviation < epsilon);
		}

		[TestMethod]
		public void GetIsRightAngledOnRightAngledTriangle_ReturnsTrue()
		{
			var aSide = 3;
			var bSide = 4;
			var cSide = 5;
			var triangle = new Triangle(aSide, bSide, cSide);

			var isRightAngled = triangle.IsRightAngled;

			Assert.IsTrue(isRightAngled);
		}

		[TestMethod]
		public void GetIsRightAngledOnNotRightAngledTriangle_ReturnsFalse()
		{
			var aSide = 6;
			var bSide = 6;
			var cSide = 6;
			var triangle = new Triangle(aSide, bSide, cSide);

			var isRightAngled = triangle.IsRightAngled;

			Assert.IsFalse(isRightAngled);
		}
    }
}
