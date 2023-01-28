namespace TestTaskAreaCalculation
{
	public class Triangle
	{
		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }
		public double SemiPerimeter { get; }
		public bool IsRectangular { get; }
		public Triangle(double sideA, double sideB, double sideC)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
			SemiPerimeter = (SideA + SideB + SideC) / 2;
			IsRectangular = CheckForRectangular();
		}

		public double GetArea()
		{
			double term = SemiPerimeter * (SemiPerimeter - SideA) * (SemiPerimeter - SideB) * (SemiPerimeter - SideC);
			double result = Math.Sqrt(term);
			return result;
		}

		private bool CheckForRectangular()
		{
			double maxSide = Math.Max(Math.Max(SideA, SideB), SideC);
			double secondSide = 0;
			double thirdSide = 0;

			if (maxSide == this.SideA)
			{
				secondSide = SideB;
				thirdSide = SideC;
			}
			if (maxSide == this.SideB)
			{
				secondSide = SideA;
				thirdSide = SideC;
			}
			if (maxSide == this.SideC)
			{
				secondSide = SideA;
				thirdSide = SideB;
			}

			double twoSidesSum = (secondSide * secondSide) + (thirdSide * thirdSide);

			if ((maxSide * maxSide) == twoSidesSum) return true;
			else return false;
		}
	}
}
