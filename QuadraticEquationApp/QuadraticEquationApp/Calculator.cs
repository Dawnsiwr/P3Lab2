using System;

namespace QuadraticEquationApp
{
	public class Calculator
	{
		private QuadraticEquation e;

		public Calculator(QuadraticEquation e)
		{
			this.e = e;
		}

		public QuadraticEquation calculateDelta()
		{
			e.setDelta(Math.Pow(e.getCoefficientB(), 2) - (4 * e.getCoefficientA() * e.getCoefficientC()));
			setRoots();
			return e;
		}

		public void setRoots()
		{
			if (e.getDelta() > 0)
				e.setRoots(Roots.TWO_SOLUTIONS);
			else if (e.getDelta() == 0)
				e.setRoots(Roots.ONE_SOLUTION);
			else
				e.setRoots(Roots.ZERO_SOLUTIONS);
		}
	}
}