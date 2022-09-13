using System;
using System.Collections.Generic;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
              throw new ArgumentException("number cannot be less than zero");
            }

            int count = 0;
            int numberCopy = number;
            int numberCopy2 = number;
            while (numberCopy > 0)
            {
                numberCopy /= 10;
                count++;
            }

            int min = number % 10;
            for (int i = 0; i < count - 1; i++)
            {
                numberCopy2 /= 10;
            }

            if (count == 0 || count == 1)
            {
                return true;
            }

            int max = numberCopy2;

            if (max == min)
            {
                return IsPalindromicNumber((int)(((number % Math.Pow(10, count - 1)) - (number % 10)) / 10));
            }

            return false;
        }
    }
}
