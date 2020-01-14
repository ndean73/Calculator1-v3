using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface IAdding {

        public double Add(int a,int b);

        public double Add(double[] ArrayValues);

    }
    public class Adding : IAdding
    {
        private double c = 0;
        public double Add(int a, int b)
        {
            c = MathOperations.Addition.Add(a,b);
            return c;
        }

        public double Add(double[] ArrayValues)
        {
            c = MathOperations.Addition.Add((int)Convert.ToDouble(ArrayValues));
            return c;
        }
    }
}
