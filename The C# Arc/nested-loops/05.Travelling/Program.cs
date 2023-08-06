using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            while (country != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double saved = 0;
                while(saved < budget)
                {
                    double deposit = double.Parse(Console.ReadLine());
                    saved += deposit;
                }
                Console.WriteLine($"Going to {country}!");

                country = Console.ReadLine();
            }
        }
    }
}