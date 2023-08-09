using System;

namespace _02.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            // Iterate through numbers:
            for (int i = start; i <= end; i++)
            {
                // Get current number:
                int numToPrint = i;

                int even = 0;
                int odd = 0;

                // Iterate through the digits, storing each in the respective variable:
                int lengthOfNumber = numToPrint.ToString().Length;
                int numToWorkWith = numToPrint;

                for(int j = 0; j < lengthOfNumber; j++)
                {
                    int lastDigit = numToWorkWith % 10;
                    numToWorkWith /= 10;


                    if(j % 2 == 0)
                    {
                        even += lastDigit;
                    } else
                    {
                        odd += lastDigit;
                    }

                }

                //Check the sum, if true print num, else do nothing:
                if (even == odd)
                {
                    Console.Write($"{numToPrint} ");
                }
            }
        }
    }
}