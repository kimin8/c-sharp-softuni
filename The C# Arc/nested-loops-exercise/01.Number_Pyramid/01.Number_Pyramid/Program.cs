using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = 1;
            for(int rows = 1; rows <= x; rows++)
            {
                for(int cols = 1; cols <= rows; cols++)
                {
                    if(n > x)
                    {
                        return;
                    } else
                    {
                        Console.Write($"{n} ");
                        n++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}