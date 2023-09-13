using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nameAct = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string nameGrad = Console.ReadLine();
                double pointsGrad = double.Parse(Console.ReadLine());
                pointsAcademy += (nameGrad.Length * pointsGrad) / 2;

                if (pointsAcademy > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameAct} got a nominee for leading role with {pointsAcademy:F1}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {nameAct} you need {1250.5 - pointsAcademy:F1} more!");
        }
    }
}