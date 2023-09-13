using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string d = "";
            double m = 0.0;
            string t = "";

            if (b <= 100)
            {
                d = "Bulgaria";

                if (s == "summer")
                {
                    t = "Camp";
                    m = b * 0.3;
                }
                else if (s == "winter")
                {
                    t = "Hotel";
                    m = b * 0.7;
                }
            }
            else if (b > 100 && b <= 1000)
            {
                d = "Balkans";

                if (s == "summer")
                {
                    t = "Camp";
                    m = b * 0.4;
                }
                else if (s == "winter")
                {
                    t = "Hotel";
                    m = b * 0.8;
                }
            }
            else if (b > 1000)
            {
                d = "Europe";
                t = "Hotel";
                m = b * 0.9;
            }

            Console.WriteLine($"Somewhere in {d}");
            Console.WriteLine($"{t} - {m:F2}");
        }
    }
}