using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVac = Convert.ToDouble(Console.ReadLine());
            int puzzlesCount = Convert.ToInt32(Console.ReadLine());
            int dollsCount = Convert.ToInt32(Console.ReadLine());
            int bearsVac = Convert.ToInt32(Console.ReadLine());
            int minionsVac = Convert.ToInt32(Console.ReadLine());
            int trucksVac = Convert.ToInt32(Console.ReadLine());
            double discount = 0;

            double sum = puzzlesCount * 2.6 + dollsCount * 3 + bearsVac * 4.1 + minionsVac * 8.2 + trucksVac * 2;
            double counts = puzzlesCount + dollsCount + bearsVac + minionsVac + trucksVac;

            if (counts >= 50)
            {
                discount += sum * 0.25;
            }

            double endPrice = sum - discount;
            double rent = endPrice * 0.1;
            double profit = endPrice - rent;

            if (profit >= priceVac)
            {
                Console.WriteLine($"Yes! {profit - priceVac:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceVac - profit:F2} lv needed.");
            }
        }
    }
}