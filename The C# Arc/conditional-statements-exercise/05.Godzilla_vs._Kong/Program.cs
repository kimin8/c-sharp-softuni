using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = Convert.ToDouble(Console.ReadLine());
            int statists = Convert.ToInt32(Console.ReadLine());
            double clothesPerSt = Convert.ToDouble(Console.ReadLine());

            double decorSum = budget * 0.1;
            double clothesSum = statists * clothesPerSt;

            if (statists > 150)
            {
                clothesSum *= 0.9;
            }

            double finalSum = decorSum + clothesSum;

            double diff = budget - finalSum;

            if (diff >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(diff):f2} leva more.");
            }
        }
    }
}