using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine()) * 100;
            int coins = 0;

            while (amount > 0)
            {
                if (amount <= 1)
                {
                    amount -= 1;
                }
                else if (amount <= 4)
                {
                    amount -= 2;
                }
                else if (amount <= 9)
                {
                    amount -= 5;
                }
                else if (amount <= 19)
                {
                    amount -= 10;
                }
                else if (amount <= 49)
                {
                    amount -= 20;
                }
                else if (amount <= 99)
                {
                    amount -= 50;
                }
                else if (amount <= 199)
                {
                    amount -= 100;
                }
                else
                {
                    amount -= 200;
                }
                coins++;
            }

            Console.WriteLine(coins);
        }
    }
}

