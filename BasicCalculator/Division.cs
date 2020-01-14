using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface IDivision
    {
        public double Div(int a, int b);
    }
    public class Division : IDivision
    {
        private int c = 0;
        public double Div(int a, int b)
        {

            c = MathOperations.Division.Div(a, b);
            return c;
        }
    }
}
