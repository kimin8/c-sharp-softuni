using System;

namespace _02.Mountian_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double time1 = distanceMeters * timePerMeter;
            double everyFifty = Math.Floor(distanceMeters / 50) * 30;
            double final = time1 + everyFifty;

            if (final >= recordSeconds)
            {
                Console.WriteLine($"No! He was {final - recordSeconds:F2} seconds slower.");
            } else
            {
                Console.WriteLine($"Yes! The new record is {final:F2} seconds.");
            }
        }
    }
}