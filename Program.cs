using System;

namespace Calculator_inator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program performs basic arithmetic operations on two numbers and displays the results.
            int num1 = 3;
            int num2 = 14;
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            // Check if num1 is greater than num2 using the modulus operator
            bool isNum1Greater = num1 > num2;
            // Display the results
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