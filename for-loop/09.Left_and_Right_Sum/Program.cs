using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= end; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= end; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}