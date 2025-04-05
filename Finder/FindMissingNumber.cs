/*
 * Author: Nicholas Li
 * 
 * FindMissingNumber.cs - Implementation of the algorithm to find the missing number.
 */

using System.Linq;

namespace MissingNumberFinder.Finder
{
    public class FindMissingNumber : INumberFinder
    {
        /// <summary>
        /// Finds the missing number in a sequence of integers.
        /// </summary>
        /// <param name="numbers">An array of integers representing the sequence.</param>
        /// <returns>The missing integer in the sequence.</returns>
        public int FindNumber(int[] numbers)
        {
            // Calculate the sum of all numbers in the array using Gauss's formula
            int expectedSum = numbers.Length * (numbers.Length + 1) / 2;

            // Calculate the actual sum
            int actualSum = numbers.Sum();

            // Actual sum minus expected sum
            return expectedSum - actualSum;
        }
    }
} 