using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 elements for the array:");

            // Initialize an array with 10 elements
            int[] array = new int[10];

            // Input values into the array
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return;
                }
            }

            // Create an object of the ArrayOperations class
            ArrayOperations arrayOps = new ArrayOperations();

            // Find and display the minimum value
            int min = arrayOps.FindMinimum(array);
            Console.WriteLine($"Minimum value: {min}");

            // Find and display the maximum value
            int max = arrayOps.FindMaximum(array);
            Console.WriteLine($"Maximum value: {max}");

            // Find and display the average value
            double average = arrayOps.FindAverage(array);
            Console.WriteLine($"Average value: {average:F2}");

            // Reverse the array and display the values
            int[] reversedArray = arrayOps.ReverseArray(array);
            Console.WriteLine("Reversed array:");
            foreach (int value in reversedArray)
            {
                Console.Write($"{value} ");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Separate class to handle array operations
    class ArrayOperations
    {
        public int FindMinimum(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public int FindMaximum(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public double FindAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }

        public int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                reversedArray[j] = array[i];
            }
            return reversedArray;
        }
    }
}
