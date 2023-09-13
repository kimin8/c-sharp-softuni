using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                if (int.Parse(input) < min)
                {
                    min = int.Parse(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}