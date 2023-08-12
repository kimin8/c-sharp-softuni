using System;

namespace _05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int day = 1;
            int meters = 5364;
            int goal = 8848;

            while(input != "END")
            {

                if(input == "Yes")
                {
                    day += 1;
                }

                int climbed = int.Parse(Console.ReadLine());

                if (day > 5)
                {
                    break;
                } else
                {
                    meters += climbed;
                }

                if(meters >= goal)
                {
                    Console.WriteLine($"Goal reached for {day} days!");
                    return;
                } else
                {
                    input = Console.ReadLine();
                }

            }

            Console.WriteLine("Failed!");
            Console.WriteLine(meters);
        }
    }
}