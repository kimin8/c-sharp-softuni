using System;

namespace _06.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int f4 = start % 10;
            start /= 10;
            int f3 = start % 10;
            start /= 10;
            int f2 = start % 10;
            start /= 10;
            int f1 = start % 10;

            int s4 = end % 10;
            end /= 10;
            int s3 = end % 10;
            end /= 10;
            int s2 = end % 10;
            end /= 10;
            int s1 = end % 10;

            for(int i = f1; i <= s1; i++)
            {
                if(i % 2 != 0)
                {
                    for (int j = f2; j <= s2; j++)
                    {
                        if(j % 2 != 0)
                        {
                            for (int k = f3; k <= s3; k++)
                            {
                                if(k % 2 != 0)
                                {
                                    for (int l = f4; l <= s4; l++)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            Console.Write($"{i}{j}{k}{l} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}