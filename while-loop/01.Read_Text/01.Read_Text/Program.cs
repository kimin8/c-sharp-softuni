using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(command);
                }
            }
        }
    }
}