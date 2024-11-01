using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 code from previous assignment (if needed, keep it here)
            string[] myArray = { "Hello", "World", "C#", "Programming" };
            Console.Write("Please enter some text to add to each array element: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] += userInput;
            }

            Console.WriteLine("\nUpdated array elements:");
            foreach (string str in myArray)
            {
                Console.WriteLine(str);
            }

            // Part 2: Infinite Loop Example
            Console.WriteLine("\nStarting an infinite loop (Press Ctrl+C to stop if not fixed):");
            
            // This is an infinite loop as written
            // for (;;)
            // {
            //     Console.WriteLine("This is an infinite loop.");
            // }

            // To fix the infinite loop, we'll add a condition to break out of it
            int counter = 0; // Initialize a counter variable to control loop iterations
            while (true) // Infinite loop condition
            {
                Console.WriteLine("This loop will stop after 5 iterations.");
                
                // Increment the counter and check if it has reached 5
                counter++;
                if (counter >= 5)
                {
                    // Break out of the loop when the counter reaches 5
                    break;
                }
            }

            Console.WriteLine("The infinite loop has been fixed and executed properly.");
            Console.ReadLine(); // Keep the console open
        }
    }
}