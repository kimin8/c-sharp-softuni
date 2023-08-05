using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            int failedTreshhold = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int probSolved = 0;
            bool isFailed = true;
            string lastProb = "";
            double gradesSum = 0;

            while (failedTimes < failedTreshhold)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }

                gradesSum += grade;
                probSolved++;
                lastProb = problemName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTreshhold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / probSolved:F2}");
                Console.WriteLine($"Number of problems: {probSolved}");
                Console.WriteLine($"Last problem: {lastProb}");
            }
        }
    }
}