using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((a * a).ToString("N3"));
            }
            else if (figure == "rectangle")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((a * b).ToString("N3"));
            }
            else if (figure == "circle")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((Math.PI * a * a).ToString("N3"));
            }
            else if (figure == "triangle")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((a * b / 2).ToString("N3"));
            }

        }
    }
}