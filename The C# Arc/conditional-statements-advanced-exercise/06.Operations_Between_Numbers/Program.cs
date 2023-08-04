using System;

namespace HUSTLE
{
    class Program
    {
        public static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            bool isEven;
            double toPrint = 0;

            switch (op)
            {
                case '+':
                    toPrint = n1 + n2;
                    isEven = toPrint % 2 == 0;
                    Console.WriteLine($"{n1} + {n2} = {toPrint} - {(isEven ? "even" : "odd")}");
                    break;
                case '-':
                    toPrint = n1 - n2;
                    isEven = toPrint % 2 == 0;
                    Console.WriteLine($"{n1} - {n2} = {toPrint} - {(isEven ? "even" : "odd")}");
                    break;
                case '*':
                    toPrint = n1 * n2;
                    isEven = toPrint % 2 == 0;
                    Console.WriteLine($"{n1} * {n2} = {toPrint} - {(isEven ? "even" : "odd")}");
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} / {n2} = {(n1 / n2):F2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    }
                    break;
            }

        }
    }
}