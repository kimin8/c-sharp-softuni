using System;

namespace coding
{
    class Program
    {
        public static void Main(string[] args)
        {
            var steps = Console.ReadLine();
            int done = 0;
            int aim = 10000;

            while (done < aim)
            {
                if (steps == "Going home")
                {
                    done += int.Parse(Console.ReadLine());
                    break;
                }

                done += int.Parse(steps);

                if (done >= aim)
                {
                    break;
                }
                steps = Console.ReadLine();

            }

            if (done >= aim)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(done - aim)} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(aim - done)} more steps to reach goal.");
            }
        }
    }
}