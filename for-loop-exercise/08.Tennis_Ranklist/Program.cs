using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int sumOfPoints = 0; ;
            double wins = 0;

            for (int i = 0; i < n; i++)
            {
                string title = Console.ReadLine();
                switch (title)
                {
                    case "W":
                        sumOfPoints += 2000;
                        wins++;
                        break;
                    case "F":
                        sumOfPoints += 1200;
                        break;
                    case "SF":
                        sumOfPoints += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {start + sumOfPoints}");
            Console.WriteLine($"Average points: {sumOfPoints / n}");
            Console.WriteLine($"{(wins / n) * 100:F2}%");
        }
    }
}