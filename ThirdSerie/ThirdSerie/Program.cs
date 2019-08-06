using System;

namespace ThirdSerie
{
    internal class Program
    {
        public static double Serie(int n, int x)
        {
            double sum = x, m = -x, c = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    c = -1;
                }
                m = c * m * x * x;
                sum += m;

            }
            return sum;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Series is  x - x^3 + x^5 - ...... ");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number of terms is ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum is {Serie(n, x)}");
        }
    }
}
