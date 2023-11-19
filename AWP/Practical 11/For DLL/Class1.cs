using System;


namespace NewMath
{
    public class Factorial
    {
        int fact = 1;
        public int factorial(int n)
        {
            while(n > 0)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }
    }
}
