using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface ISubtraction
    {

        public double Sub(int a, int b);

    }
    public class Subtraction : ISubtraction
    {
        private int c = 0;
        public double Sub(int a, int b)
        {

            c = MathOperations.Subtraction.Sub(a, b);
            return c;
        }

        
    }
}
