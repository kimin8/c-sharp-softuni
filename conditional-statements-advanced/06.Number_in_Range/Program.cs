using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine((x >= -100 && x != 0 && x <= 100) ? "Yes" : "No");
        }
    }
}