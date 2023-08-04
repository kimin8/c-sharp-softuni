using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int mix = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double sum = pens * 5.8 + markers * 7.2 + mix * 1.2;

            Console.Write(sum - sum * discount / 100);

        }
    }
}