using System;

namespace _01.PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceCPU = double.Parse(Console.ReadLine());
            double priceGPU = double.Parse(Console.ReadLine());
            double priceRAM = double.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double priceCPULV = priceCPU * 1.57;
            double priceGPULV = priceGPU * 1.57;
            double priceRAMLV = priceRAM * 1.57;

            double RAM = priceRAMLV * countRam;
            double CPU = priceCPULV * (1 - discount);
            double GPU = priceGPULV * (1 - discount);

            Console.WriteLine($"Money needed - {RAM + CPU + GPU:F2} leva.");
        }
    }
}