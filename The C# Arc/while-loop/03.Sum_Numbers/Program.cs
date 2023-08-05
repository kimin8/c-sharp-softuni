using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < goal)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"{sum}");
        }
    }
}