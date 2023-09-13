using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x > biggest)
                {
                    biggest = x;

                }
                sum += x;
            }

            if (sum / biggest == 2 && sum % biggest == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggest}");
            }
            else
            {
                int sumWithoutElement = sum - biggest;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(biggest - sumWithoutElement)}");
            }
        }
    }
}