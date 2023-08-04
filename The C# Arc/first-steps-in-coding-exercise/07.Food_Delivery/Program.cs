using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.4;
            double vegetarianPrice = vegetarianMenu * 8.15;

            double finalPriceMenus = chickenPrice + fishPrice + vegetarianPrice;
            double dessertPrice = finalPriceMenus * 0.2;
            const double deliveryPrice = 2.5;

            double finalPriceOrder = finalPriceMenus + dessertPrice + deliveryPrice;

            Console.WriteLine(finalPriceOrder);
        }
    }
}