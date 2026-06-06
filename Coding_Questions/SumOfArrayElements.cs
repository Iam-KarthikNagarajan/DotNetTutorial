using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coding_Questions
{
    public class SumOfArrayElements
    {
        public int CalculateSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
