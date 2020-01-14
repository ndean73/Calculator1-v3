using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class Cube
    {

        public static double CubeRoot(double a)
        {

            //return Math.Sqrt(a);
            return Math.Ceiling(Math.Pow(a, (double)1 / 3));

        }

        public static int CubeRoot(int b)
        {
            int c = 1;

            c = CubeRoot(b);


            return c;
        }
    }
}
