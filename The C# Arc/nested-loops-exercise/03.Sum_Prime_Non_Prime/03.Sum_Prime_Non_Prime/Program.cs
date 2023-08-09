using System;

namespace _03.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int prime = 0;
            int notPrime = 0;

            while(input != "stop")
            {
                int number = int.Parse(input);

                if(number < 0)
                {
                    Console.WriteLine("Number is negative.");
                } else
                {
                    int counter = 0;

                    for(int i = 1; i < number; i++)
                    {
                        if(number % i == 0)
                        {
                            counter++;
                        }
                    }

                    if(counter >= 2)
                    {
                        notPrime += number;
                    } else
                    {
                        prime += number;
                    }
                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrime}");
        }
    }
}