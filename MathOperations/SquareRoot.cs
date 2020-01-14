using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    ////SquareRoot
        public class SquareRoot
    {


        public static double SqrRoot(double a)
        {

             return Math.Sqrt(a);
           
        }

        public static int SqrRoot(int b)
        {
            int c = 0;

                c = SqrRoot(b);
            

            return c;
        }
    }
}
