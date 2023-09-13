using System;

namespace _05.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            double unpaintable = double.Parse(Console.ReadLine());

            double allWallsArea = h * w * 4;
            double areaToPaint = allWallsArea - Math.Ceiling(allWallsArea * (unpaintable / 100));

            var input = Console.ReadLine();
            while(input != "Tired!")
            {
                int paint = int.Parse(input);

                areaToPaint -= paint;
                if(areaToPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaToPaint)} l paint left!");
                    return;
                } else if(areaToPaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{areaToPaint} quadratic m left.");
        }
    }
}