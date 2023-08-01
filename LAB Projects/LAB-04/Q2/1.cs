using System;

namespace CircleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Properties Calculator!");

            // Ask for the radius input
            Console.Write("Please enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            // Parse the input to a double
            if (double.TryParse(radiusInput, out double radius))
            {
                // Calculate the area and circumference of the circle
                double area = Math.PI * Math.Pow(radius, 2);
                double circumference = 2 * Math.PI * radius;

                // Display the results
                Console.WriteLine($"Area of the circle: {area:F2}");
                Console.WriteLine($"Circumference of the circle: {circumference:F2}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number for the radius.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
