using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < end; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < smallest)
                {
                    smallest = num;
                }

                if (num > biggest)
                {
                    biggest = num;
                }
            }

            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}