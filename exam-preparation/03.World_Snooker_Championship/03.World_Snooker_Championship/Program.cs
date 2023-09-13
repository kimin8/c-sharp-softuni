using System;

namespace _03.World_Snooker_Championship 
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double priceForTicket = 0.0;
            double finalPrice = 0.0;

            switch(stage)
            {
                case "Quarter final":
                    if(typeTicket == "Standard")
                    {
                        priceForTicket = 55.5;
                    } else if(typeTicket == "Premium")
                    {
                        priceForTicket = 105.2;
                    } else
                    {
                        priceForTicket = 118.9;
                    }
                    break;
                case "Semi final":
                    if (typeTicket == "Standard")
                    {
                        priceForTicket = 75.88;
                    }
                    else if (typeTicket == "Premium")
                    {
                        priceForTicket = 125.22;
                    }
                    else
                    {
                        priceForTicket = 300.4;
                    }
                    break;
                case "Final":
                    if (typeTicket == "Standard")
                    {
                        priceForTicket = 110.1;
                    }
                    else if (typeTicket == "Premium")
                    {
                        priceForTicket = 160.66;
                    }
                    else
                    {
                        priceForTicket = 400;
                    }
                    break;
            }

            finalPrice += priceForTicket * count;

            if(finalPrice > 2500 && finalPrice <= 4000)
            {
                finalPrice *= 0.9;
                if(photo == 'Y')
                {
                    finalPrice += 40 * count;
                }
            } else if(finalPrice > 4000)
            {
                finalPrice *= 0.75;
            } else
            {
                if (photo == 'Y')
                {
                    finalPrice += 40 * count;
                }
            }

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}