using System;

namespace _06.Cinema_Tickets 
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int studentTickets = 0;
            int standartTickets = 0;
            int kidTickets = 0;

            while (movieName != "Finish")
            {
                double seatCount = double.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                double ticketsCount = 0;

                while(ticketType != "End")
                {
                    switch(ticketType)
                    {
                        case "standard":
                            standartTickets++;
                            ticketsCount++;
                            break;
                        case "student":
                            studentTickets++;
                            ticketsCount++;
                            break;
                        case "kid":
                            kidTickets++;
                            ticketsCount++;
                            break;
                    }

                    if(seatCount == ticketsCount)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                Console.WriteLine($"{movieName} - {ticketsCount / seatCount * 100:F2}% full.");
                movieName = Console.ReadLine();

            }

            double sum = studentTickets + standartTickets + kidTickets;
            Console.WriteLine($"Total tickets: {sum}");
            Console.WriteLine($"{studentTickets / sum * 100:F2}% student tickets.");
            Console.WriteLine($"{standartTickets / sum * 100:F2}% standard tickets.");
            Console.WriteLine($"{kidTickets / sum * 100:F2}% kids tickets.");
        }
    }
}