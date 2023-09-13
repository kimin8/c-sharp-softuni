using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for(int i = x; i >= 1; i--)
            {
                for(int j = 0; j < y; j++)
                {
                    if(i == x)
                    {
                        Console.Write($"L{i}{j} ");
                    } else
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"O{i}{j} ");
                        } else
                        {
                            Console.Write($"A{i}{j} ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}