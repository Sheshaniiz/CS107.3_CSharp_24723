using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sum of Digits Calculator!");

            // Ask for the number input
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Parse the user input to a long (to handle large numbers)
            if (long.TryParse(userInput, out long number))
            {
                long sumOfDigits = 0;

                // Find the sum of digits using a for loop
                while (number > 0)
                {
                    long digit = number % 10;
                    sumOfDigits += digit;
                    number /= 10;
                }

                // Print the result
                Console.WriteLine($"Sum of the digits: {sumOfDigits}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
