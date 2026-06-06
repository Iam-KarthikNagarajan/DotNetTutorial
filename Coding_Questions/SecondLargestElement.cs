using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class SecondLargestElement
    {
        public int FindSecondLargest(int[] array)
        {
            int largest = array[0];
            int secondLargest = int.MinValue;

            for (int i = 1; i < array.Length; i++)
            {
                if (largest < array[i])
                {
                    secondLargest = largest;
                    largest = array[i];
                }
                else if (secondLargest < array[i] && array[i] != largest)
                {
                    secondLargest = array[i];
                }
            }
            return secondLargest;
        }
    }
}
