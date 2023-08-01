using System;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Dog class
            Dog dog = new Dog();

            // Call the methods of the Dog class and the Animal class to display the required output
            dog.DisplayAnimalInfo();

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Animal class (Base class)
    class Animal
    {
        public void DisplayAnimalInfo()
        {
            Console.WriteLine("I am an animal");
        }
    }

    // Dog class (Derived class)
    class Dog : Animal
    {
        public new void DisplayAnimalInfo()
        {
            base.DisplayAnimalInfo(); // Call the method in the base class
            Console.WriteLine("I have four legs");
        }
    }
}
