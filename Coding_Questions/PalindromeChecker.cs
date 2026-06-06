using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (input == null) // Edge case
                return false;

            StringBuilder reversed = new StringBuilder(); // Empty string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]); // Reverse the string
            }
            return input.Equals(reversed.ToString());
        }
    }
}
