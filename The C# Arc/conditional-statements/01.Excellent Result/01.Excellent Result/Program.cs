using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = Convert.ToDouble(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}