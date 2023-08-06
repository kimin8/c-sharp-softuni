using System;

namespace _04.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    count++;
                    if (i + j == n)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {n})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations - neither equals {n}");
        }
    }
}