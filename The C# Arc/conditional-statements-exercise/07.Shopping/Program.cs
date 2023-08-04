using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = Convert.ToDouble(Console.ReadLine());
            int gpu = Convert.ToInt32(Console.ReadLine());
            int cpu = Convert.ToInt32(Console.ReadLine());
            int ram = Convert.ToInt32(Console.ReadLine());

            double gpuPrice = gpu * 250;
            double cpuPrice = (0.35 * gpuPrice) * cpu;
            double ramPrice = (0.1 * gpuPrice) * ram;

            double finalPrice = gpuPrice + cpuPrice + ramPrice;

            if (gpu > cpu)
            {
                finalPrice *= 0.85;
            }

            if (finalPrice > budget)
            {
                Console.WriteLine($"Not enough money! You need {finalPrice - budget:f2} leva more!");
            }
            else
            {
                Console.WriteLine($"You have {budget - finalPrice:f2} leva left!");
            }
        }
    }
}