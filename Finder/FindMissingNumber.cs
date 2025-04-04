/*
 * Author: Nicholas Li
 * 
 * FindMissingNumber.cs - Implementation of the algorithm to find the missing number.
 */

namespace MissingNumberFinder.Finder
{
    public class FindMissingNumber : INumberFinder
    {
        /// <summary>
        /// Finds the missing number in a sequence of integers.
        /// </summary>
        /// <param name="nums">An array of integers representing the sequence.</param>
        /// <returns>The missing integer in the sequence.</returns>
        public int FindMissingNumber(int[] nums)
        {
            // Calculate the sum of all numbers in the array using Gauss's formula
            int expectedSum = nums.Length * (nums.Length + 1) / 2;

            // Calculate the actual sum
            int actualSum = nums.Sum();

            // Actual sum minus expected sum
            return expectedSum - actualSum;
        }
    }
} 