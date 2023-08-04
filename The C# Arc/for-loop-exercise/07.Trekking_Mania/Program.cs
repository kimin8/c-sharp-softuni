using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            double mu = 0;
            double mon = 0;
            double ki = 0;
            double k2 = 0;
            double ev = 0;

            for (int i = 0; i < n; i++)
            {
                int hikers = int.Parse(Console.ReadLine());
                sum += hikers;
                if (hikers <= 5)
                {
                    mu += hikers;
                }
                else if (hikers >= 6 && hikers <= 12)
                {
                    mon += hikers;
                }
                else if (hikers >= 13 && hikers <= 25)
                {
                    ki += hikers;
                }
                else if (hikers >= 26 && hikers <= 40)
                {
                    k2 += hikers;
                }
                else if (hikers >= 41)
                {
                    ev += hikers;
                }
            }

            Console.WriteLine($"{mu / sum * 100:F2}%");
            Console.WriteLine($"{mon / sum * 100:F2}%");
            Console.WriteLine($"{ki / sum * 100:F2}%");
            Console.WriteLine($"{k2 / sum * 100:F2}%");
            Console.WriteLine($"{ev / sum * 100:F2}%");

        }
    }
}