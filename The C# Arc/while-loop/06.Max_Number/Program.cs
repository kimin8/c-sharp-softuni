using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while (input != "Stop")
            {
                if (int.Parse(input) > max)
                {
                    max = int.Parse(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}