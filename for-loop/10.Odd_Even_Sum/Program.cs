using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < end; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += x;
                }
                else
                {
                    oddSum += x;
                }

            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}