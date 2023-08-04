using System;
namespace hustling
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double priceForWholeYard = area * 7.61;
            double discount = priceForWholeYard * 0.18;
            double finalPrice = priceForWholeYard - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}