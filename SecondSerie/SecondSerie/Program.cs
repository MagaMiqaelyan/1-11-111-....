using System;

namespace SecondSerie
{
    internal class Program
    {
        public static double Serie(int n, int x)
        {
            double sum = 1, m = 1;
            for (int i = 1; i < n; i++)
            {
                m = x * m / (float)i;
                sum += m;
            }
            return sum;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Series is 1+x+x^2/2!+x^3/3!+... ");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number of terms is ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum is {Serie(n, x)}");
        }
    }
}
