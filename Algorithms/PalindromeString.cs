using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class PalindromeString
    {
        public static bool IsPalindrome(this string givenString)
        {
            string firstHalf = givenString.Substring(0, givenString.Length / 2);

            string secondHalf = givenString.Substring((int)Math.Ceiling(givenString.Length / 2D)).ReverseStr();

            return string.Equals(firstHalf, secondHalf, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
