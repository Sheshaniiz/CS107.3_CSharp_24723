using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator!");

            // Ask for the first number input
            Console.Write("Please enter the first number: ");
            string firstInput = Console.ReadLine();

            // Ask for the second number input
            Console.Write("Please enter the second number: ");
            string secondInput = Console.ReadLine();

            // Parse the inputs to doubles
            if (double.TryParse(firstInput, out double firstNumber) && double.TryParse(secondInput, out double secondNumber))
            {
                // Calculate the sum
                double sum = firstNumber + secondNumber;
                Console.WriteLine($"Sum: {sum}");

                // Calculate the subtraction
                double subtraction = firstNumber - secondNumber;
                Console.WriteLine($"Subtraction: {subtraction}");

                // Calculate the multiplication
                double multiplication = firstNumber * secondNumber;
                Console.WriteLine($"Multiplication: {multiplication}");

                // Check for division by zero
                if (secondNumber != 0)
                {
                    // Calculate the division
                    double division = firstNumber / secondNumber;
                    Console.WriteLine($"Division: {division}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
