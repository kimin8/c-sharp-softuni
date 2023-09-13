using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            double needed = double.Parse(Console.ReadLine());
            double available = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (available < needed && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    available += money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    available -= money;
                    spendingCounter++;

                    if (available < 0)
                    {
                        available = 0;
                    }
                }
            }


            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (available >= needed)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }

        }
    }
}