/*
 * Author: Nicholas Li
 * 
 * CheckValidation.cs - Encapsulates all validation logic with aggregated error reporting.
 */

using System.Collections.Generic;
using System.Linq;

namespace MissingNumberFinder.Validation
{
    public class CheckValidation
    {
        private readonly List<ValidationDelegate> _validations;
        private delegate string ValidationDelegate(int[] numbers);

        /// <summary>
        /// Initializes with default validations
        /// </summary>
        public CheckValidation()
        {
            _validations = new List<ValidationDelegate>
            {
                ValidateNull,
                ValidateEmpty,
                ValidateDuplicates
            };
        }

        /// <summary>
        /// Validates the input array and returns all validation errors
        /// </summary>
        /// <param name="numbers">The array to validate</param>
        /// <returns>List of error messages, empty if valid</returns>
        public List<string> ValidateInputWithAllErrors(int[] numbers)
        {
            var errors = new List<string>();
            
            foreach (var validation in _validations)
            {
                string error = validation(numbers);
                if (error != null)
                {
                    errors.Add(error);
                    
                    // Skip dependent validations if null check fails
                    if (error == "Input array cannot be null")
                        break;
                }
            }
            
            return errors;
        }

        /// <summary>
        /// Validates the input array against all validation rules
        /// </summary>
        /// <param name="numbers">The array to validate</param>
        /// <returns>First error message if invalid, null if valid</returns>
        public string ValidateInput(int[] numbers)
        {
            var errors = ValidateInputWithAllErrors(numbers);
            return errors.FirstOrDefault();
        }

        /// <summary>
        /// Simplified validation for quick boolean check
        /// </summary>
        /// <param name="numbers">The array to validate</param>
        /// <returns>True if valid, false if invalid</returns>
        public bool IsValidInput(int[] numbers)
        {
            return !ValidateInputWithAllErrors(numbers).Any();
        }

        // Individual validation methods
        private string ValidateNull(int[] numbers)
        {
            if (numbers == null)
            {
                return "Input array cannot be null";
            }
            return null;
        }

        private string ValidateEmpty(int[] numbers)
        {
            if (numbers == null)
            {
                return null; 
            }
            
            if (numbers.Length == 0)
            {
                return "Input array cannot be empty";
            }
            
            return null;
        }

        private string ValidateDuplicates(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return null; 
            }
            
            var set = new HashSet<int>(numbers);
            if (set.Count != numbers.Length)
            {
                return "Input array cannot contain duplicate values";
            }
            
            if (set.Any(n => n < 0 || n > numbers.Length))
            {
                return "All values must be between 0 and the length of the array";
            }
            
            return null;
        }
    }
} 