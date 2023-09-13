using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;
            int toys = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    toys++;
                }
            }

            money += toys * toyPrice;

            Console.WriteLine($"{(money >= washingMachine ? $"Yes! {money - washingMachine:F2}" : $"No! {washingMachine - money:F2}")}");

        }
    }
}