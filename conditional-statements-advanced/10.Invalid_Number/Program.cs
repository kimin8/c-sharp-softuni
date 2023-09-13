using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(((x >= 100 && x <= 200 || x == 0) ? null : "invalid"));
        }
    }
}