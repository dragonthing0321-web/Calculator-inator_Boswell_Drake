using System;

namespace Calculator_inator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 14;
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            bool isNum1Greater = num1 % 2 == 0;

            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
            Console.WriteLine($"Is {num1} greater than {num2}?: {isNum1Greater}");
        }
    }
}