using System;
using MathOperations;

namespace BasicCalculator
{
    public interface IBasicCalculator {

        public double Add(int a,int b);
        public double Add(double[] ArrayValues);
        public double Div(int a,int b);
        public double Sub(int a,int b);
        public double Multi(double a,double b);
        public double Sqr(double a,double b);
        public int SqrRoot(int a);
        public double Cub(int a);
    
    }

    public class BasicCalculator : IAdding,ISubtraction,IDivision,IMultiplication,ICube,ISquare,ISquareRoot
    {
        private  double a = 0;
        
        Adding add = new Adding();
        Subtraction sub = new Subtraction();
        Multiplication multi = new Multiplication();
        Division div = new Division();
        Cube cub = new Cube();
        Square sqr = new Square();
        SquareRoot sqrroot = new SquareRoot();

        public double result;

        public double Add(int a,int b)
        {
           result=add.Add(a,b);
           return result;
        }

        public double Add(double[] ArrayValues)
        {
            result = add.Add(ArrayValues);
            return result;
        }

        public double Cub(int a)
        {
            result= cub.Cub(a);
            return result;
        }

        public double Div(int a,int b)
        {
           result= div.Div(a, b);
           return result;
        }

        public double Multi(double a,double b)
        {
            result= multi.Multi(a, b);
            return result;
        }

        public double Sqr(double a,double b)
        {
            result=sqr.Sqr(a,b);
            return result;
        }

        public double SqrRoot(int a)
        {
            result = sqrroot.SqrRoot(a);
            return result;
        }

        public double Sub(int a,int b)
        {
           result = sub.Sub(a,b);
           return result;

        }

       
    }
}
