using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface IMultiplication
    {

        public double Multi(double a, double b);

    }
    public class Multiplication : IMultiplication
    {
        private double c = 0;
        public double Multi(double a, double b)
        {

            c = MathOperations.Multiplication.Multi(a, b);
            return c;
        }
    }
}
