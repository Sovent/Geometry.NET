using System;

namespace Geometry.NET
{
	public class Circle : Shape
	{
		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException("Radius should be positive number");
			}
			Radius = radius;
		}

		public double Radius { get; }

		public override double Area => Math.PI * Radius * Radius;

		public override double Perimeter => 2 * Math.PI * Radius;
	}
}
