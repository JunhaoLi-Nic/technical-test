/*
 * Author: Nicholas Li
 * 
 * CheckValidation.cs - Validates input data before processing.
 */

using System;

namespace MissingNumberFinder.Validation
{
    public class CheckValidation
    {
        /// <summary>
        /// Validates the input array for the missing number finder algorithm
        /// </summary>
        /// <param name="nums">The input array to validate</param>
        /// <returns>Error message if invalid, null if valid</returns>
        public string ValidateInput(int[] nums)
        {
            // Check array is not null
            if (nums == null)
            {
                return "Input array cannot be null";
            }

            // Check array is not empty
            if (nums.Length == 0)
            {
                return "Input array cannot be empty";
            }

            // All validations passed
            return null; // null means valid
        }
    }
} 