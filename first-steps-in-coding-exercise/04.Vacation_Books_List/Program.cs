using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            Console.Write(pagesCount / pagesPerHour / daysToRead);

        }
    }
}
