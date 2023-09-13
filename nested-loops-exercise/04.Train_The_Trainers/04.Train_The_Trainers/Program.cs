using System;

namespace _04.Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            double final = 0.0;
            int count = 0;
            string presentationName = Console.ReadLine();

            while (presentationName != "Finish")
            {
                int judges = int.Parse(input);
                double sum = 0.0;

                for(int i = 1; i <= judges; i++)
                {
                    sum += double.Parse(Console.ReadLine());
                }

                final += sum / judges;
                count++;
                Console.WriteLine($"{presentationName} - {sum / judges:F2}.");

                presentationName = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {final / count:F2}.");
        }
    }
}