using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arithmetic Operations Calculator!");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            // Ask for the user's choice
            Console.Write("Enter your choice (1/2/3/4): ");
            string choiceInput = Console.ReadLine();

            // Parse the choice input to an integer
            if (int.TryParse(choiceInput, out int choice))
            {
                if (choice >= 1 && choice <= 4)
                {
                    // Ask for the two numbers input
                    Console.Write("Please enter the first number: ");
                    string num1Input = Console.ReadLine();

                    Console.Write("Please enter the second number: ");
                    string num2Input = Console.ReadLine();

                    // Parse the input numbers to doubles
                    if (double.TryParse(num1Input, out double num1) && double.TryParse(num2Input, out double num2))
                    {
                        // Create an object of the CalculateValues class
                        CalculateValues calculator = new CalculateValues();

                        // Perform the selected arithmetic operation and store the result
                        double result = 0;
                        switch (choice)
                        {
                            case 1: // Addition
                                result = calculator.Addition(num1, num2);
                                break;
                            case 2: // Subtraction
                                result = calculator.Subtraction(num1, num2);
                                break;
                            case 3: // Multiplication
                                result = calculator.Multiplication(num1, num2);
                                break;
                            case 4: // Division
                                result = calculator.Division(num1, num2);
                                break;
                        }

                        // Display the result
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid input. Please enter valid numbers for calculations.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid choice. Please enter a valid choice (1/2/3/4).");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid choice (1/2/3/4).");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Separate class to handle arithmetic operations
    class CalculateValues
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
        }
    }
}
