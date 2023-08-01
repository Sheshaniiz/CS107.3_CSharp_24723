using System;

namespace KilometerToMeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kilometer to Meter Converter!");

            // Ask for the kilometer input
            Console.Write("Please enter the distance in kilometers: ");
            string kmInput = Console.ReadLine();

            // Parse the input to a double
            if (double.TryParse(kmInput, out double kilometers))
            {
                // Create an object of the ConvertValues class
                ConvertValues converter = new ConvertValues();

                // Call the KilometerToMeter method with the kilometers as a parameter and store the result
                double meters = converter.KilometerToMeter(kilometers);

                // Display the result
                Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number for kilometers.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Separate class to handle conversions
    class ConvertValues
    {
        public double KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            return meters;
        }
    }
}
