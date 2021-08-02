using System;

namespace DataTypes_Lib
{
    public static class Methods
    {   
            
            // ALL DONE
            // DONE

        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {

            long total = 1;

            for (int i = 1; i <= n; i++)
            {
                total *= i;
            }

            return total;

        }

            // DONE

        public static float Mult(float num1, float num2)
        {
            float result = num1 * num2;
            return (float)Math.Round(result, 1);

        }
    }
}
