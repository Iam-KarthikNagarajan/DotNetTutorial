using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class AnagramChecker
    {
        public bool AreAnagrams(string str1, string str2)
        {
            if (str1 == null || str2 == null) // Edge case
                return false;

            if (str1.Length != str2.Length)
                return false;

            char[] charArray1 = str1.ToLower().ToCharArray(); // Case-insensitive
            char[] charArray2 = str2.ToLower().ToCharArray();

            Array.Sort(charArray1); // Sort the characters
            Array.Sort(charArray2);

            //for (int i = 0; i < charArray1.Length; i++) // Check if lengths are equal
            //{
            //    if(charArray1[i] != charArray2[i]) // Compare sorted characters
            //        return false;
            //}

            return new string(charArray1).Equals(new string(charArray2)); // Compare sorted strings
        }
    }
}
