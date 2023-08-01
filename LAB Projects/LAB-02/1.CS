using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum Calculator!");

            // Ask for the first number input
            Console.Write("Please enter the first number: ");
            string firstInput = Console.ReadLine();

            // Ask for the second number input
            Console.Write("Please enter the second number: ");
            string secondInput = Console.ReadLine();

            // Parse the inputs to doubles
            if (double.TryParse(firstInput, out double firstNumber) && double.TryParse(secondInput, out double secondNumber))
            {
                // Calculate the sum of the two numbers
                double sum = firstNumber + secondNumber;

                // Print the result
                Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
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
