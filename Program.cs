/*
 * Author: Nicholas Li
 * 
 * Program.cs - Main entry point that demonstrates finding missing numbers.
 */

using System;
using MissingNumberFinder.Finder;
using MissingNumberFinder.ProcessingService;
using MissingNumberFinder.Validation;

namespace MissingNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create dependencies
            INumberFinder finder = new FindMissingNumber();
            CheckValidation validator = new CheckValidation();
            
            // Create processor
            var processor = new FindWithSelectedMethod(finder, validator);
            
            // Get input from command line or use example
            int[] inputArray;
            if (args.Length > 0)
            {
                try
                {
                    inputArray = Array.ConvertAll(args, int.Parse);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: All arguments must be integers.");
                    return;
                }
            }
            else
            {
                // Example input if no command line args provided
                inputArray = new[] { 3, 0, 1 };
                Console.WriteLine("Using example input: [3, 0, 1]");
            }
            
            // Process and display the result
            var result = processor.Process(inputArray);
            
            if (result.Success)
            {
                Console.WriteLine($"Success! The missing number is: {result.Result}");
            }
            else
            {
                Console.WriteLine("Validation failed with the following errors:");
                Console.WriteLine(result.Error);
            }
        }
    }
} 