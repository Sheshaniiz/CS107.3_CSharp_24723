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
                // Create an object of the FindValues class
                FindValues calculator = new FindValues();

                // Call the FindArea method with the radius as a parameter and store the returned result
                double area = calculator.FindArea(radius);

                // Call the FindCircumference method with the radius as a parameter and store the returned result
                double circumference = calculator.FindCircumference(radius);

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

    // Separate class to handle calculations
    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
