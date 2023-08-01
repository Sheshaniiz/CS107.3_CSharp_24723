using System;

namespace SalaryAfterTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Salary After Tax Calculator!");

            // Ask for the salary input
            Console.Write("Please enter the employee's salary: ");
            string salaryInput = Console.ReadLine();

            // Ask for the tax rate input
            Console.Write("Please enter the tax rate (in decimal format, e.g., 0.20 for 20%): ");
            string taxRateInput = Console.ReadLine();

            // Parse the inputs to doubles
            if (double.TryParse(salaryInput, out double salary) && double.TryParse(taxRateInput, out double taxRate))
            {
                // Check if the tax rate is within the valid range
                if (taxRate >= 0 && taxRate <= 1)
                {
                    // Calculate the salary after tax deduction
                    double salaryAfterTax = salary * (1 - taxRate);

                    // Print the result
                    Console.WriteLine($"Salary after tax deduction: {salaryAfterTax:C2}");
                }
                else
                {
                    Console.WriteLine("Error: The tax rate should be between 0 and 1 (inclusive).");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers for salary and tax rate.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
