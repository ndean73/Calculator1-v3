using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    ///Multiplication
    public class Multiplication
    {


        public static double Multi(double a, double b)
        {
            return a * b;
        }

        public static double Multi(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA)
            {
                c = Multi(a, c);
            }

            return c;
        }
    }
}
