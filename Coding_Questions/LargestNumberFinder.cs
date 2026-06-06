using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class LargestNumberFinder
    {
        public int FindLargestNumber(int[] array) {
            if (array == null) return 0;

            int largest = array[0];

            for(int i = 1; i < array.Length; i++) {
                if (largest < array[i]) {
                    largest = array[i];   
                }
            }
            return largest;
        }
    }
}
