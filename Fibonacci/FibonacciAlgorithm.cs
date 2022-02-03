using System;
using System.Collections.Generic;

namespace Fibonacci
{
    /// <summary>
    /// Fn= Fn-1 + Fn-2
    /// </summary>
    public class FibonacciAlgorithm
    {
        #region Naiif (basic) 

        public static int Fibonacci_Basic(int n)
        {
            int fn;

            if (n > 1)
            {
                fn = Fibonacci_Basic(n - 1) + Fibonacci_Basic(n - 2);
            }

            else { fn = n; }

            return fn;
        }

        #endregion


        #region Advanced (Dynamic programming)


        #region Recursive (Top-Bottom) with Memoization    

        public static int Fibonacci_TopBottom(int n)
        {
            if (n < 2) { return n; }

            int?[] memoArray = new int?[n + 1];
      
            InitializeFibonocciArray(memoArray);          

            return Fibonacci_TopBottom_Helper(n, memoArray);
        }



        public static int Fibonacci_TopBottom_Helper(int n, int?[] memoArray)
        {
            int fn;

            if (memoArray[n] != null)
            {
                fn = (int)memoArray[n];
            }
            else
            {
                fn = Fibonacci_TopBottom_Helper(n - 1, memoArray) + Fibonacci_TopBottom_Helper(n - 2, memoArray);
                memoArray[n] = fn;
            }

            return fn;
        }

        #endregion


        #region  Bottom-Top Algorithm

        public static int Fibonacci_BottomTop(int n)
        {
            if (n < 2)
            {
                return n;
            }

            int[] fibonocciArray = new int[n + 1];          

            InitializeFibonocciArray(fibonocciArray);

            for (int i = 2; i <= n; i++)
            {
                fibonocciArray[i] = fibonocciArray[i - 1] + fibonocciArray[i - 2];
            }

            return fibonocciArray[n];
        }

        private static void InitializeFibonocciArray(int?[] febonucciArray)
        {
            febonucciArray[0] = 0;
            febonucciArray[1] = 1;
        }

        private static void InitializeFibonocciArray(int[] fibonocciArray)
        {
            fibonocciArray[0] = 0;
            fibonocciArray[1] = 1;
        }

        #endregion


        #endregion

    }
}
