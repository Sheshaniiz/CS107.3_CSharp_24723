using System;

namespace CircleAreaAndCircumferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Area and Circumference Calculator!");

            // Ask for the radius input
            Console.Write("Please enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            // Parse the radius input to a double
            if (double.TryParse(radiusInput, out double radius))
            {
                // Check if the radius is non-negative
                if (radius >= 0)
                {
                    // Calculate the area of the circle
                    double area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Area of the circle: {area:F2}");

                    // Calculate the circumference of the circle
                    double circumference = 2 * Math.PI * radius;
                    Console.WriteLine($"Circumference of the circle: {circumference:F2}");
                }
                else
                {
                    Console.WriteLine("Error: The radius cannot be negative.");
                }
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
