using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    ////Square
    public class Square
    {


        public static double Sqr(double a,double b)
        {

            return Math.Pow(a,b);

        }

        public static double Sqr(double b)
        {
            double c = 2;

            c = Sqr(b,c);
            
            return c;
        }
    }
}
