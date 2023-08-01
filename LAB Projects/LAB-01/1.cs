using System;

namespace NameAndBatchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Name and Batch Console App!");
            
            // Ask for name input
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            // Ask for batch input
            Console.Write("Please enter your batch: ");
            string batch = Console.ReadLine();

            // Print the inputs
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Batch: {batch}");

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
