using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int distiller = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nailonPrice = (nailon + 2) * 1.50;
            double paintPrice = (paint + paint * 0.1) * 14.5;
            double distillerPrice = distiller * 5;
            double bagsPrice = 0.4;
            double priceForMaterials = nailonPrice + paintPrice + distillerPrice + bagsPrice;
            double sumForWorkers = (priceForMaterials * 30 / 100) * hours;
            double finalPrice = priceForMaterials + sumForWorkers;

            Console.WriteLine(finalPrice);
        }
    }
}