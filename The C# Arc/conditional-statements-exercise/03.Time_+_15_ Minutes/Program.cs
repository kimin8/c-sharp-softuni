using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursInput = Convert.ToInt32(Console.ReadLine());
            int minutesInput = Convert.ToInt32(Console.ReadLine());

            int hoursToPrint;
            int minutesToPrint;

            if (hoursInput == 23 && minutesInput >= 45)
            {
                hoursToPrint = 0;
                minutesToPrint = minutesInput - 45;
                if (minutesToPrint < 10)
                {
                    Console.WriteLine($"{hoursToPrint}:0{minutesToPrint}");
                }
                else
                {
                    Console.WriteLine($"{hoursToPrint}:{minutesToPrint}");
                }

                return;
            }

            if (minutesInput >= 45)
            {
                hoursToPrint = hoursInput + 1;
                minutesToPrint = minutesInput - 45;

                if (minutesToPrint < 10)
                {
                    Console.WriteLine($"{hoursToPrint}:0{minutesToPrint}");
                }
                else
                {
                    Console.WriteLine($"{hoursToPrint}:{minutesToPrint}");
                }
                return;
            }

            hoursToPrint = hoursInput;
            minutesToPrint = minutesInput + 15;

            if (minutesToPrint < 10)
            {
                Console.WriteLine($"{hoursToPrint}:0{minutesToPrint}");
            }
            else
            {
                Console.WriteLine($"{hoursToPrint}:{minutesToPrint}");
            }
        }
    }
}