using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            double d = 0.0;
            double f = 0.0;

            switch (s)
            {
                case "Spring":
                    f += 3000;
                    break;
                case "Summer":
                case "Autumn":
                    f += 4200;
                    break;
                case "Winter":
                    f += 2600;
                    break;
            }

            if (c <= 6)
            {
                d += 0.1;
            }
            else if (c >= 7 && c <= 11)
            {
                d += 0.15;
            }
            else if (c >= 12)
            {
                d += 0.25;
            }

            f *= 1 - d;

            if (c % 2 == 0 && s != "Autumn")
            {
                f *= 0.95;
            }

            if (b >= f)
            {
                Console.WriteLine($"Yes! You have {b - f:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {f - b:F2} leva.");
            }
        }
    }
}