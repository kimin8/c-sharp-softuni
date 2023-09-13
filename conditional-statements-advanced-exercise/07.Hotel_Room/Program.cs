using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double stdPr = 0.0;
            double aptPr = 0.0;

            switch (m)
            {
                case "May":
                case "October":
                    stdPr = 50;
                    aptPr = 65;

                    if (n > 7 && n <= 14)
                    {
                        stdPr *= 0.95;
                    }
                    else if (n > 14)
                    {
                        stdPr *= 0.7;
                        aptPr *= 0.9;
                    }

                    break;
                case "June":
                case "September":
                    stdPr = 75.2;
                    aptPr = 68.7;

                    if (n > 14)
                    {
                        stdPr *= 0.8;
                        aptPr *= 0.9;
                    }

                    break;
                case "July":
                case "August":
                    stdPr = 76;
                    aptPr = 77;

                    if (n > 14)
                    {
                        aptPr *= 0.9;
                    }

                    break;
            }

            Console.WriteLine($"Apartment: {aptPr * n:F2} lv.");
            Console.WriteLine($"Studio: {stdPr * n:F2} lv.");
        }
    }
}