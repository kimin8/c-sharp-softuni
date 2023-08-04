using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double comission = 0;

            switch (city)
            {
                case "Sofia":
                    if (x >= 0 && x <= 500)
                    {
                        comission = x * 0.05;
                    }
                    else if (x > 500 && x <= 1000)
                    {
                        comission = x * 0.07;
                    }
                    else if (x > 1000 && x <= 10000)
                    {
                        comission = x * 0.08;
                    }
                    else if (x > 10000)
                    {
                        comission = x * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;

                case "Varna":
                    if (x >= 0 && x <= 500)
                    {
                        comission = x * 0.045;
                    }
                    else if (x > 500 && x <= 1000)
                    {
                        comission = x * 0.075;
                    }
                    else if (x > 1000 && x <= 10000)
                    {
                        comission = x * 0.1;
                    }
                    else if (x > 10000)
                    {
                        comission = x * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;

                case "Plovdiv":
                    if (x >= 0 && x <= 500)
                    {
                        comission = x * 0.055;
                    }
                    else if (x > 500 && x <= 1000)
                    {
                        comission = x * 0.08;
                    }
                    else if (x > 1000 && x <= 10000)
                    {
                        comission = x * 0.12;
                    }
                    else if (x > 10000)
                    {
                        comission = x * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    return;
            }

            Console.WriteLine($"{comission:F2}");
        }
    }
}