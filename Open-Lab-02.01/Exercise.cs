using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            return new double [5] { 1, 2, 3, 4, 5 };
        }

        public double GetSecond(double[] numbers)
        {
           
            double cislo = numbers [ 1 ];
            return cislo;
        }
    }
}