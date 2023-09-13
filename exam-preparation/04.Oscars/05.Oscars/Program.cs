using System;

namespace _04.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            for(int i = 1; i <= judges; i++)
            {
                string judgeName = Console.ReadLine();
                double pointJudge = double.Parse(Console.ReadLine());

                pointsAcademy += judgeName.Length * pointJudge / 2;
                if(pointsAcademy > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsAcademy:F1}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsAcademy:F1} more!");
        }
    }
}