using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = r * c * 12;
            }
            else if (type == "Normal")
            {
                income = r * c * 7.5;
            }
            else if (type == "Discount")
            {
                income = r * c * 5;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}