using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class Addition
    {

        public static double Add(double[] ArrayValues)
        {
            int c = 0;

            foreach(int i in ArrayValues)
            {
                 c = i + c;
            }
           
            return c;

        }

        public  static int Add(int a, int b)
        {
            return a + b;
        }

       /* public static int Add(int a)
        {
           
           int c = 0;
            
                c = Add(a, c);
            
            return c;
        }*/

        


    }
}
