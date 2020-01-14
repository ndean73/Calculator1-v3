using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    ///Subtraction
    public class Subtraction
    {


        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Sub(int[] arrayA)
        {
            int c = 0;

            foreach (int a in arrayA)
            {
                c = Sub(a, c);
            }

            return c;
        }
    }
}

