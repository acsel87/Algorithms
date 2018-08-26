using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class WaysToClimbStairs
    {
        /// <summary>
        /// Mindblown....
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long WaysToReachNthStair(this int n)
        {
            return Fib(n + 1);
        }

        private static long Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
                
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
