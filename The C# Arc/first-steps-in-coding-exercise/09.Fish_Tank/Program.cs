using System;

namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lengthCm * widthCm * heightCm;
            double volLitre = volume * 0.001;
            double takenSpace = percent * 0.01;
            Console.WriteLine(volLitre * (1 - takenSpace));


        }
    }
}