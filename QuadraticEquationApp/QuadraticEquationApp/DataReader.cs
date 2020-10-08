using System;

namespace QuadraticEquationApp
{
    public class DataReader
    {
        public QuadraticEquation quadraticEquationCoefficientReader()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            bool error;
            do
            {
                error = false;
                Console.WriteLine("Enter coefficient A (A!=0)");
                if (!double.TryParse(Console.ReadLine(), out a) || a == 0)
                {
                    error = true;
                    continue;
                }

                Console.WriteLine("Enter coefficient B");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    error = true;
                    continue;
                }

                Console.WriteLine("Enter coefficient C");
                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    error = true;
                    continue;
                }

            } while (error == true);

            return new QuadraticEquation(a, b, c);
        }
    }
}
