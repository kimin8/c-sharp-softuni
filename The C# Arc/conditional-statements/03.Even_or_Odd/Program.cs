using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a % 2 == 0 ? "even" : "odd");
        }
    }
}