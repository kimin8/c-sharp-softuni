using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int space = w * l * h;
            var command = Console.ReadLine();
            while (command != "Done")
            {
                int taken = int.Parse(command);
                space -= taken;

                if (space < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                    return;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{space} Cubic meters left.");
        }
    }
}