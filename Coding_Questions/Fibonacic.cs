using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Questions
{
    public class Fibonacic
    {
        public long GenerateFibonacci(int n)
        {
            if (n < 0) // Fibonacci is not defined for negative numbers
                return -1;
            else if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            long a = 0, b = 1, fib = 0;
            Console.Write(a + ", " + b );

            for (int i = 2; i < n; i++)
            {
                fib = a + b;
                Console.Write(", " + fib);

                a = b;
                b = fib;
            }
            return fib;
        }
    }
}
