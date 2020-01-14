using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface ISquare
    {

        public double Sqr(double a, double b);

    }
    public class Square : ISquare
    {
        private double c = 0;
        public double Sqr(double a, double b)
        {

            c = MathOperations.Square.Sqr(a, b);
            return c;
        }
    }
}
