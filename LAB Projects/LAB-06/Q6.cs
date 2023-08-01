using System;

namespace ArrayInputWithZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                // Create an object of the SeparateArray class
                SeparateArray separateArray = new SeparateArray();

                // Call the method in the SeparateArray class to take user inputs for the array
                int[] array = separateArray.TakeUserInputs(size);

                // Print all the values inside the array
                Console.WriteLine("Values inside the array:");
                foreach (int value in array)
                {
                    Console.Write($"{value} ");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer for the array size.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Separate class to handle array operations
    class SeparateArray
    {
        public int[] TakeUserInputs(int size)
        {
            int[] array = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i * 2] = value;
                    array[i * 2 + 1] = 0;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return new int[0]; // Return an empty array if input is invalid
                }
            }
            return array;
        }
    }
}
