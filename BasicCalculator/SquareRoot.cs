using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface ISquareRoot
    {

        public double SqrRoot(int a);

    }
    public class SquareRoot : ISquareRoot
    {
        private int c = 0;
        public double SqrRoot(int a)
        {
            c = MathOperations.SquareRoot.SqrRoot(a);
            return c;
        }
    }
}

