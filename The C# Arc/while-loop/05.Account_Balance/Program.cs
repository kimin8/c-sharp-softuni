using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0.0;

            while (input != "NoMoreMoney")
            {
                double deposit = double.Parse(input);
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += deposit;
                Console.WriteLine($"Increase: {deposit:F2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}