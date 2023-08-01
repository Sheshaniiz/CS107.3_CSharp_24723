using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vowel Counter!");

            // Ask for the string input
            Console.Write("Please enter a string: ");
            string inputString = Console.ReadLine();

            // Convert the input string to lowercase (to consider both uppercase and lowercase vowels)
            string lowerCaseInput = inputString.ToLower();

            int vowelCount = 0;
            foreach (char c in lowerCaseInput)
            {
                if (IsVowel(c))
                {
                    vowelCount++;
                }
            }

            // Print the result
            Console.WriteLine($"Number of vowels in the given string: {vowelCount}");

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Helper method to check if a character is a vowel
        static bool IsVowel(char c)
        {
            return "aeiou".Contains(c);
        }
    }
}
