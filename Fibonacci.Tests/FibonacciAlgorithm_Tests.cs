using System;
using Xunit;
using static Xunit.Assert;

namespace Fibonacci.Tests
{
    public class FibonacciAlgorithm_Tests
    {
        /// <summary>
        /// Testing  Fibonacci basic (naiif) algorithm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="expectedValue"></param>
        [Theory]

        [InlineData(0,0)]
        [InlineData(1,1)]

        [InlineData(2,1)]
        [InlineData(3,2)]      
        [InlineData(15, 610)]       
        public void Fibonacci_Basic_CheckIfResultFollowsFibnacciSequence(int n, int expectedValue)
        {
            var fn = FibonacciAlgorithm.Fibonacci_Basic(n);

            Equal( expectedValue,fn);
        }

        /// <summary>
        /// Testing  Fibonacci advanced (TopBottom) algorithm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="expectedValue"></param>
        [Theory]

        [InlineData(0, 0)]
        [InlineData(1, 1)]

        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(15, 610)]
        public void Fibonacci_TopBottom_CheckIfResultFollowsFibonacciSequence(int n, int expectedValue)
        {
            var fn = FibonacciAlgorithm.Fibonacci_TopBottom(n);

            Equal(expectedValue, fn);
        }

        /// <summary>
        /// Testing  Fibonacci advanced (BottomTop) algorithm
        /// </summary>
        /// <param name="n"></param>
        /// <param name="expectedValue"></param>
        [Theory]

        [InlineData(0, 0)]
        [InlineData(1, 1)]

        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(15, 610)]
        public void Fibonacci_BottomTop_CheckIfResultFollowsFibonacciSequence(int n, int expectedValue)
        {
            var fn = FibonacciAlgorithm.Fibonacci_BottomTop(n);

            Equal(expectedValue, fn);
        }
    }
}
