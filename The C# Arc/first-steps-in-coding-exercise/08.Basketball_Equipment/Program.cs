using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse(Console.ReadLine());
            double sneakers = yearlyTax - yearlyTax * 0.4;
            double clothes = sneakers - sneakers * 0.2;
            double ball = clothes / 4;
            double accessories = ball / 5;

            Console.WriteLine(yearlyTax + sneakers + clothes + ball + accessories);
        }
    }
}