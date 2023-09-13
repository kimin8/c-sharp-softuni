using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 200)
                {
                    p1++;
                }
                else if (x >= 200 && x <= 399)
                {
                    p2++;
                }
                else if (x >= 400 && x <= 599)
                {
                    p3++;
                }
                else if (x >= 600 && x <= 799)
                {
                    p4++;
                }
                else if (x >= 800)
                {
                    p5++;
                }
            }

            Console.WriteLine($"{p1 / n * 100:F2}%");
            Console.WriteLine($"{p2 / n * 100:F2}%");
            Console.WriteLine($"{p3 / n * 100:F2}%");
            Console.WriteLine($"{p4 / n * 100:F2}%");
            Console.WriteLine($"{p5 / n * 100:F2}%");
        }
    }
}