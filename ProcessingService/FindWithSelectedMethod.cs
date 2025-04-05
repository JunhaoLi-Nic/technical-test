/*
 * Author: Nicholas Li
 * 
 * FindWithSelectedMethod.cs - Processing service with aggregated validation.
 */

using System;
using System.Linq;
using MissingNumberFinder.Finder;
using MissingNumberFinder.Validation;

namespace MissingNumberFinder.ProcessingService
{
    /// <summary>
    /// Processes missing number requests with validated dependencies
    /// </summary>
    public class FindWithSelectedMethod
    {
        private readonly INumberFinder _numberFinder;
        private readonly CheckValidation _validator;

        /// <summary>
        /// Constructor for dependency injection
        /// </summary>
        /// <param name="numberFinder">The algorithm implementation to use</param>
        /// <param name="validator">The validation service to use</param>
        public FindWithSelectedMethod(INumberFinder numberFinder, CheckValidation validator)
        {
            _numberFinder = numberFinder ?? throw new ArgumentNullException(nameof(numberFinder));
            _validator = validator ?? throw new ArgumentNullException(nameof(validator));
        }

        /// <summary>
        /// Processes the input array to find the missing number with validation
        /// </summary>
        /// <param name="numbers">Array of integers to process</param>
        /// <returns>Result containing success, value and error details</returns>
        public (bool Success, int Result, string Error) Process(int[] numbers)
        {
            // Validate input with aggregated errors
            var validationErrors = _validator.ValidateInputWithAllErrors(numbers);
            if (validationErrors.Any())
            {
                // Join all errors with line breaks for better readability
                return (false, -1, string.Join(Environment.NewLine, validationErrors));
            }

            // Process with the finder
            try
            {
                int result = _numberFinder.FindNumber(numbers);
                return (true, result, null);
            }
            catch (Exception ex)
            {
                return (false, -1, $"Error finding missing number: {ex.Message}");
            }
        }
    }
} 