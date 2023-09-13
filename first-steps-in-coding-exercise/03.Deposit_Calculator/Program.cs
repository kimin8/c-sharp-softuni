using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int dueDate = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double interestSum = deposit * interest * 0.01;
            double interestPerMonth = interestSum / 12;
            double finalPrice = deposit + dueDate * interestPerMonth;

            Console.Write(finalPrice);

        }
    }
}
