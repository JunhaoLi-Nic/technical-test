/*
 * Author: Nicholas Li
 * 
 * INumberFinder.cs - Interface defining the contract for finding a missing number.
 */

namespace MissingNumberFinder.Finder
{
    public interface INumberFinder
    {
        /// <summary>
        /// Finds the missing number in a sequence of integers.
        /// </summary>
        /// <param name="numbers">An array of integers representing the sequence.</param>
        /// <returns>The missing integer in the sequence.</returns>
        int FindNumber(int[] numbers);
    }
} 