using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b));
        }
    }
}