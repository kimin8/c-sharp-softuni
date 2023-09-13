using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            int points = 0;

            for (int i = 0; i <= txt.Length - 1; i++)
            {
                switch (txt[i])
                {
                    case 'a':
                        points += 1;
                        break;
                    case 'e':
                        points += 2;
                        break;
                    case 'i':
                        points += 3;
                        break;
                    case 'o':
                        points += 4;
                        break;
                    case 'u':
                        points += 5;
                        break;
                }
            }

            Console.WriteLine(points);
        }
    }
}