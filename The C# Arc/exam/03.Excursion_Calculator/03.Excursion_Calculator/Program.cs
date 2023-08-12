using System;

namespace _03.Excursion_Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double priceOne = 0.0;

            switch(season)
            {
                case "spring":
                    if(people <= 5)
                    {
                        priceOne = 50;
                    } else
                    {
                        priceOne = 48;
                    }
                    break;
                case "summer":
                    if (people <= 5)
                    {
                        priceOne = 48.5;
                    }
                    else
                    {
                        priceOne = 45;
                    }
                    break;
                case "autumn":
                    if (people <= 5)
                    {
                        priceOne = 60;
                    }
                    else
                    {
                        priceOne = 49.5;
                    }
                    break;
                case "winter":
                    if (people <= 5)
                    {
                        priceOne = 86;
                    }
                    else
                    {
                        priceOne = 85;
                    }
                    break;
            }

            double final = people * priceOne; 

            if(season == "summer")
            {
                final *= 0.85;
            } else if(season == "winter")
            {
                final *= 1.08;
            }

            Console.WriteLine($"{final:F2} leva.");
        }
    }
}