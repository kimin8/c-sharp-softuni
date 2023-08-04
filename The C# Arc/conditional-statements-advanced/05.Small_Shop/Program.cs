using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        price += 0.5 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price += 0.4 * quantity;
                    }
                    else if (city == "Varna")
                    {
                        price += 0.45 * quantity;
                    }
                    break;

                case "water":
                    if (city == "Sofia")
                    {
                        price += 0.8 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price += 0.7 * quantity;
                    }
                    else if (city == "Varna")
                    {
                        price += 0.7 * quantity;
                    }
                    break;

                case "beer":
                    if (city == "Sofia")
                    {
                        price += 1.2 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price += 1.15 * quantity;
                    }
                    else if (city == "Varna")
                    {
                        price += 1.1 * quantity;
                    }
                    break;

                case "sweets":
                    if (city == "Sofia")
                    {
                        price += 1.45 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price += 1.30 * quantity;
                    }
                    else if (city == "Varna")
                    {
                        price += 1.35 * quantity;
                    }
                    break;

                case "peanuts":
                    if (city == "Sofia")
                    {
                        price += 1.6 * quantity;
                    }
                    else if (city == "Plovdiv")
                    {
                        price += 1.5 * quantity;
                    }
                    else if (city == "Varna")
                    {
                        price += 1.55 * quantity;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}