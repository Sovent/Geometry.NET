using System;

namespace Geometry.NET
{
	public class Triangle : Shape
	{
		public Triangle(double aSideLength, double bSideLength, double cSideLength)
		{
			if (!IsValidTriangle(aSideLength, bSideLength, cSideLength))
			{
				throw new ArgumentException("Can not construct triangle with presented arguments");
			}

			ASideLength = aSideLength;
			BSideLength = bSideLength;
			CSideLength = cSideLength;
		}

		public double ASideLength { get; }
		public double BSideLength { get; }
		public double CSideLength { get; }
		
		public static bool IsValidTriangle(
			double aSideLength, 
			double bSideLength, 
			double cSideLength)
		{
			if (aSideLength <= 0 || bSideLength <= 0 || cSideLength <= 0)
			{
				return false;
			}

			return (aSideLength + bSideLength > cSideLength
				&& aSideLength + cSideLength > bSideLength
				&& bSideLength + cSideLength > aSideLength);
		}

		public override double Area
		{
			get
			{
				var halfPerimeter = Perimeter / 2;
				return Math.Sqrt(
					halfPerimeter 
					* (halfPerimeter - ASideLength) 
					* (halfPerimeter - BSideLength) 
					* (halfPerimeter - CSideLength));
			}
		}

		public bool IsRightAngled
		{
			get
			{
				var squaredASide = ASideLength * ASideLength;
				var squaredBSide = BSideLength * BSideLength;
				var squaredCSide = CSideLength * CSideLength;

				return squaredASide == squaredBSide + squaredCSide
					|| squaredBSide == squaredASide + squaredCSide
					|| squaredCSide == squaredASide + squaredBSide;
			}
		}
		public override double Perimeter => ASideLength + BSideLength + CSideLength;
	}
}
