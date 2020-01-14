using System;
using MathOperations;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface ICube {

        public double Cub(int a);
    }
    public class Cube : ICube
    {
        private double a = 0;

        public double Cub(int a)
        {
            a = MathOperations.Cube.CubeRoot(a);
            return a;
        }
    }
}
