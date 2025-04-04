/*
 * Author: Nicholas Li
 * 
 * FindWithSelectedMethod.cs - Processing service that uses dependency injection to find missing numbers.
 */

using MissingNumberFinder.Finder;

namespace MissingNumberFinder.ProcessingService
{
    public class FindWithSelectedMethod
    {
        private readonly INumberFinder _numberFinder;

        public FindWithSelectedMethod(INumberFinder numberFinder)
        {
            // dependency injection - can be replaced with different finding methods
            _numberFinder = numberFinder;
        }

        public int FindMissingNumber(int[] nums)
        {
            return _numberFinder.FindMissingNumber(nums);
        }

    }
} 