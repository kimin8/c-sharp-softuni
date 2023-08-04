using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            int sum = first + second + third;
            int minutes = sum / 60;
            int seconds = sum % 60;

            string secondsToPrint = Convert.ToString(seconds);
            if (seconds < 10 && seconds >= 0)
            {
                secondsToPrint = "0" + seconds;
            }

            Console.WriteLine($"{minutes}:{secondsToPrint}");
        }
    }
}