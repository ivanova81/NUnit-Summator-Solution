using System;

namespace Summator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });
            if (sum == 21)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

            double average = Summator.Average(new int[] { 8, 13, 22 });
            if (average == 14)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}
