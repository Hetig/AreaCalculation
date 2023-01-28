namespace TestTaskAreaCalculation
{
	public class Circle
	{
		public double Radius { get; }
		public const double Pi = 3.14;

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double GetArea()
		{
			double result = Pi * (Radius * Radius);
			return result;
		}
	}
}