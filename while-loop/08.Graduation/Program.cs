using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int current = 1;
            int failed = 0;
            double sumGrades = 0;
            bool fail = false;

            while (current <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    failed++;
                }
                else if (grade >= 4.00)
                {
                    current++;
                    sumGrades += grade;
                }

                if (failed >= 2)
                {

                    fail = true;
                    break;
                }
            }

            double averageGrade = sumGrades / 12;

            if (fail)
            {
                Console.WriteLine($"{name} has been excluded at {current} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}