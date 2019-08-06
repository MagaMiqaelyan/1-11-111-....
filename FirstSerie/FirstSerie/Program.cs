using System;

namespace FirstSerie
{
    internal class Program
    {
        public static int Serie(int n)
        {
            int sum = 1, value = 1;

            for (int i = 1; i < n; i++)
            {
                value = 10 * value + 1;
                Console.Write(value + " ");
                sum = sum + value;
            }
            return sum;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("THIS IS SERIES 1+11+111+....");
            Console.Write("The terms of series is ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum is  " + Serie(n));
        }
    }
}
