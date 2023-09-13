using System;

namespace _02.Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirt = double.Parse(Console.ReadLine());
            double priceToReach = double.Parse(Console.ReadLine());

            double shorts = shirt * 0.75;
            double socks = shorts * 0.2;
            double shoes = (shirt + shorts) * 2;
            double sum = shirt + shorts + socks + shoes;

            double afterDisc = sum * 0.85;

            if(afterDisc >= priceToReach)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {afterDisc:F2} lv.");
            } else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {priceToReach - afterDisc:F2} lv. more.");
            }
        }
    }
}