using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fav = Console.ReadLine();
            string inp = Console.ReadLine();
            int count = 0;

            while (inp != "No More Books")
            {
                if (inp == fav)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                else
                {
                    count++;
                    inp = Console.ReadLine();
                }
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");
        }
    }
}