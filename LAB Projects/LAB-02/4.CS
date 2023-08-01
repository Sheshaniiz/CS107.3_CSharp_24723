using System;

namespace EvenOrOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Even or Odd Checker!");

            // Ask for the number input
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Parse the user input to an integer
            if (int.TryParse(userInput, out int number))
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
