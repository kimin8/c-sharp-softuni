using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string attempt = Console.ReadLine();
            while (attempt != password)
            {
                attempt = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}