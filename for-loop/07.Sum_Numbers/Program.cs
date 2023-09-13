using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < end; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}