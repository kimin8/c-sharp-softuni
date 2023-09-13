using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            for (int i = 0; i <= txt.Length - 1; i++)
            {
                Console.WriteLine(txt[i]);
            }
        }
    }
}