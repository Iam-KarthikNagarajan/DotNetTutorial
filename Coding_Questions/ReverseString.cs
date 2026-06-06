using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class ReverseString
    {
        public string ReverseStringMethod(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input; // Return the original string if it's null or empty
            }

            char[] charArray = input.ToCharArray(); // Convert the string to a character array
            Array.Reverse(charArray); // Reverse the character array
            return new string(charArray); // Convert the reversed character array back to a string

            //StringBuilder reversed = new StringBuilder(); // Empty string

            //// Iterate all elements in reverse order
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed.Append(input[i]); // yppa ...
            //}
            //return reversed.ToString();
        }
    }
}
