using System;
namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            String archName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());


            Console.WriteLine($"The architect {archName} will need {projectCount * 3} hours to complete {projectCount} project/s.");

        }
    }
}
