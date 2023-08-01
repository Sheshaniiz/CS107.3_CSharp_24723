using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the arrays:");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                // Initialize two arrays with the user-specified size
                int[] array1 = new int[size];
                int[] array2 = new int[size];

                // Input values for the first array
                Console.WriteLine("Enter values for Array 1:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array1[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        return;
                    }
                }

                // Input values for the second array
                Console.WriteLine("Enter values for Array 2:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        array2[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        return;
                    }
                }

                // Calculate and display the Scalar Sum
                int scalarSum = CalculateScalarSum(array1, array2);
                Console.WriteLine($"Scalar Sum: {scalarSum}");

                // Calculate and display the Vector Sum
                int[] vectorSum = CalculateVectorSum(array1, array2);
                Console.WriteLine("Vector Sum:");
                DisplayArray(vectorSum);

                // Calculate and display the Vector Product
                int[] vectorProduct = CalculateVectorProduct(array1, array2);
                Console.WriteLine("Vector Product:");
                DisplayArray(vectorProduct);

                // Calculate and display the Scalar Product
                int scalarProduct = CalculateScalarProduct(array1, array2);
                Console.WriteLine($"Scalar Product: {scalarProduct}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid positive integer for the array size.");
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to calculate the Scalar Sum
        static int CalculateScalarSum(int[] arr1, int[] arr2)
        {
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i] + arr2[i];
            }
            return sum;
        }

        // Method to calculate the Vector Sum
        static int[] CalculateVectorSum(int[] arr1, int[] arr2)
        {
            int[] sumArray = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArray[i] = arr1[i] + arr2[i];
            }
            return sumArray;
        }

        // Method to calculate the Vector Product
        static int[] CalculateVectorProduct(int[] arr1, int[] arr2)
        {
            int[] productArray = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                productArray[i] = arr1[i] * arr2[i];
            }
            return productArray;
        }

        // Method to calculate the Scalar Product
        static int CalculateScalarProduct(int[] arr1, int[] arr2)
        {
            int product = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                product += arr1[i] * arr2[i];
            }
            return product;
        }

        // Method to display the contents of an array
        static void DisplayArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
