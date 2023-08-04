using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            int episode = Convert.ToInt32(Console.ReadLine());
            int breakD = Convert.ToInt32(Console.ReadLine());

            double reqTime = episode + (1 / 8.0) * breakD + (1 / 4.0) * breakD;

            if (reqTime <= breakD)
            {
                Console.WriteLine($"You have enough time to watch {title} and left with {Math.Ceiling(breakD - reqTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {title}, you need {Math.Ceiling(reqTime - breakD)} more minutes.");
            }
        }
    }
}