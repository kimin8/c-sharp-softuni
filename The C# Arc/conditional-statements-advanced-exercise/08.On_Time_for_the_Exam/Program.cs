using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            int eh = int.Parse(Console.ReadLine());
            int em = int.Parse(Console.ReadLine());
            int ah = int.Parse(Console.ReadLine());
            int am = int.Parse(Console.ReadLine());

            int examTime = eh * 60 + em;
            int arrivalTime = ah * 60 + am;

            int diff = examTime - arrivalTime;

            string verdict = "";
            string keyword = "";

            if (diff < 0)
            {
                verdict = "Late";
                keyword = "after";
            }
            else
            {
                keyword = "before";
                if (diff <= 30)
                {
                    verdict = "On time";
                }
                else
                {
                    verdict = "Early";
                }
            }

            string formattedTime = "";
            int absDiff = Math.Abs(diff);

            if (absDiff < 60)
            {
                formattedTime = $"{absDiff} minutes";
            }
            else
            {
                int diffH = absDiff / 60;
                int diffM = absDiff % 60;

                if (diffM < 10)
                {
                    formattedTime = $"{diffH}:0{diffM} hours";
                }
                else
                {
                    formattedTime = $"{diffH}:{diffM} hours";
                }
            }

            Console.WriteLine(verdict);

            if (diff != 0)
            {
                Console.WriteLine($"{formattedTime} {keyword} the start");
            }
        }
    }
}