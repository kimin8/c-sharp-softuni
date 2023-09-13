using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string g = Console.ReadLine();
            double finalPr = 0.0;

            switch (t)
            {
                case "room for one person":
                    double rPr = 18 * (d - 1);

                    if (g == "positive")
                    {
                        rPr *= 1.25;
                    }
                    else if (g == "negative")
                    {
                        rPr *= 0.9;
                    }

                    finalPr = rPr;

                    break;
                case "apartment":
                    double aPr = 25 * (d - 1);

                    if (d < 10)
                    {
                        aPr *= 0.7;
                    }
                    else if (d >= 10 && d <= 15)
                    {
                        aPr *= 0.65;
                    }
                    else if (d > 15)
                    {
                        aPr *= 0.5;
                    }

                    if (g == "positive")
                    {
                        aPr *= 1.25;
                    }
                    else if (g == "negative")
                    {
                        aPr *= 0.9;
                    }

                    finalPr = aPr;

                    break;
                case "president apartment":
                    double pPr = 35 * (d - 1);

                    if (d < 10)
                    {
                        pPr *= 0.9;
                    }
                    else if (d >= 10 && d <= 15)
                    {
                        pPr *= 0.85;
                    }
                    else if (d > 15)
                    {
                        pPr *= 0.8;
                    }

                    if (g == "positive")
                    {
                        pPr *= 1.25;
                    }
                    else if (g == "negative")
                    {
                        pPr *= 0.9;
                    }

                    finalPr = pPr;

                    break;
            }

            Console.WriteLine($"{finalPr:F2}");
        }
    }
}