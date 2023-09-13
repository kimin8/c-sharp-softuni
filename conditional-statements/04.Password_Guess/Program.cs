using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            Console.WriteLine(a == "s3cr3t!P@ssw0rd" ? "Welcome" : "Wrong password!");
        }
    }
}