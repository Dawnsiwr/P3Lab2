using System;

namespace QuadraticEquationApp
{
	public class QuadraticEquation
	{
		private double coefficientA;
		private double coefficientB;
		private double coefficientC;
		private double delta;
		private Roots roots;

		public QuadraticEquation(double coefficientA, double coefficientB, double coefficientC)
		{
			this.coefficientA = coefficientA;
			this.coefficientB = coefficientB;
			this.coefficientC = coefficientC;

		}


		public double getCoefficientA()
		{
			return coefficientA;
		}

		public void setCoefficientA(double coefficientA)
		{
			this.coefficientA = coefficientA;
		}

		public double getCoefficientB()
		{
			return coefficientB;
		}

		public void setCoefficientB(double coefficientB)
		{
			this.coefficientB = coefficientB;
		}

		public double getCoefficientC()
		{
			return coefficientC;
		}

		public void setCoefficientC(double coefficientC)
		{
			this.coefficientC = coefficientC;
		}

		public double getDelta()
		{
			return delta;
		}

		public void setDelta(double delta)
		{
			this.delta = delta;
		}



		public Roots getRoots()
		{
			return roots;
		}


		public void setRoots(Roots roots)
		{
			this.roots = roots;
		}

		public void printResult()
		{
			Console.Clear();
			Console.Write("QuadraticEquation: " + coefficientA + "x^2 + " + coefficientB + "x + " + coefficientC
					+ "\nDelta = " + delta
					+ "\n" + roots);
			switch (roots)
			{
				case Roots.ZERO_SOLUTIONS:
					{
					}
					break;
				case Roots.ONE_SOLUTION:
					{
						double firstRoot = (-coefficientB) / (2 * coefficientA);
						Console.Write(" -> x0 = " + firstRoot);
					}
					break;
				case Roots.TWO_SOLUTIONS:
					{
						double firstRoot = (-coefficientB - Math.Sqrt(delta)) / (2 * coefficientA);
						double secondRoot = (-coefficientB + Math.Sqrt(delta)) / (2 * coefficientA);
						Console.Write(" -> x1 = " + firstRoot + " | x2 = " + secondRoot);
					}
					break;
			}
		}
	}
}