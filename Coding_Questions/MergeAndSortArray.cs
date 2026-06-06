using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class MergeAndSortArray
    {
        public int[] MergeAndSort(int[] array1, int[] array2)
        {
            int len1 = array1.Length;
            int len2 = array2.Length;
            int[] mergedArray = new int[len1 + len2];

            //for (int i = 0; i < len1; i++)
            //{
            //    mergedArray[i] = array1[i];
            //}

            //for (int i = 0; i < len2; i++)
            //{
            //    mergedArray[len1 + i] = array2[i];
            //}

            // Copy elements from first array
            Array.Copy(array1, 0, mergedArray, 0, len1);
            // Copy elements from second array
            Array.Copy(array2, 0, mergedArray, len1, len2);


            Array.Sort(mergedArray);

            return mergedArray;
        }
    }
}
