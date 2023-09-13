using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = Convert.ToInt32(Console.ReadLine());
            double bonusPoints = 0;

            if (points >= 0 && points <= 100)
            {
                bonusPoints += 5;
            } else if (points > 100 && points <= 1000)
            {
                bonusPoints += points * 0.2;
            } else
            {
                bonusPoints += points * 0.1;
            }

            if (points % 2 == 0)
            {
                bonusPoints += 1;
            } else if (points % 5 == 0)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}