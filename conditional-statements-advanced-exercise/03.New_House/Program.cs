using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string ft = Console.ReadLine();
            int fc = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double final = 0.0;

            switch (ft)
            {
                case "Roses":
                    final += fc * 5;
                    if (fc > 80)
                    {
                        final *= 0.9;
                    }
                    break;
                case "Dahlias":
                    final += fc * 3.8;
                    if (fc > 90)
                    {
                        final *= 0.85;
                    }
                    break;
                case "Tulips":
                    final += fc * 2.8;
                    if (fc > 80)
                    {
                        final *= 0.85;
                    }
                    break;
                case "Narcissus":
                    final += fc * 3;
                    if (fc < 120)
                    {
                        final *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    final += fc * 2.5;
                    if (fc < 80)
                    {
                        final *= 1.2;
                    }
                    break;
            }

            if (b >= final)
            {
                double ret = b - final;
                Console.WriteLine($"Hey, you have a great garden with {fc} {ft} and {ret:F2} leva left.");
            }
            else
            {
                double ret = final - b;
                Console.WriteLine($"Not enough money, you need {ret:F2} leva more.");
            }
        }
    }
}