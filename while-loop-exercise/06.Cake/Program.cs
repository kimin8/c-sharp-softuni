using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int pieces = w * l;
            var command = Console.ReadLine();
            while (command != "STOP")
            {
                int taken = int.Parse(command);
                pieces -= taken;

                if (pieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    return;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}