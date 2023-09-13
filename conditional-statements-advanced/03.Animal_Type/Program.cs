using System;

namespace hustling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dayName = Console.ReadLine();

            switch (dayName)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}