using System;

namespace _04.Computer_Firm 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumRating = 0.0;
            double final = 0.0;

            for(int i = 1; i <= n; i++)
            {
                int rating = int.Parse(Console.ReadLine());
                int lastDigit = rating % 10;
                int possibleSales = rating / 10;
                switch(lastDigit)
                {
                    case 2:
                        final += 0;
                        break;
                    case 3:
                        final += possibleSales * 0.5;
                        break;
                    case 4:
                        final += possibleSales * 0.7;
                        break;
                    case 5:
                        final += possibleSales * 0.85;
                        break;
                    case 6:
                        final += possibleSales;
                        break;
                }

                sumRating += lastDigit;
            }

            Console.WriteLine($"{final:F2}");
            Console.WriteLine($"{sumRating / n:F2}");
        }
    }
}