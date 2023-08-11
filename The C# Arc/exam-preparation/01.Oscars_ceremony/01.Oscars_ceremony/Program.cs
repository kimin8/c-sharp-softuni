using System;

namespace _01.Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rent = decimal.Parse(Console.ReadLine());
            decimal statuesPrice = rent - (30 * rent / 100);
            decimal catering = statuesPrice - (15 * statuesPrice / 100);
            decimal sound = catering / 2;

            Console.WriteLine($"{rent + statuesPrice + catering + sound:F2}");
        }
    }
}