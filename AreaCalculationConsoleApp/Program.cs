using TestTaskAreaCalculation;

namespace AreaCalculationConsoleApp
{
	public class Program
	{
		public static void Main()
		{
			var triangle = new Triangle(39, 80, 89);
			Console.WriteLine(triangle.IsRectangular);
		}
	}
}
