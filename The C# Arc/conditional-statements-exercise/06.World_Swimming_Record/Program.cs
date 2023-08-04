using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = Convert.ToDouble(Console.ReadLine());
            double distanceM = Convert.ToDouble(Console.ReadLine());
            double oneMeter = Convert.ToDouble(Console.ReadLine());

            double distance = distanceM * oneMeter;
            double bonus = Math.Floor(distanceM / 15) * 12.5;
            double finalTime = distance + bonus;


            if (finalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - finalTime):f2} seconds slower.");
            }

        }
    }
}