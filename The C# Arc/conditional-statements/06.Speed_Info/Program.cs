﻿using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            if (a <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (a > 10 && a <= 50)
            {
                Console.WriteLine("average");
            }
            else if (a > 50 && a <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (a > 150 && a <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}