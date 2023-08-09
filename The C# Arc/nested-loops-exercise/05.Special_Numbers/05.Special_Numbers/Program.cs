using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                int numToWork = i;
                for(int j = 1; j <= 4; j++)
                {
                    int lastDigit = numToWork % 10;
                    numToWork /= 10;


                    if(lastDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    if(N % lastDigit != 0)
                    {
                        isSpecial = false;
                    }
                }

                if(isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}