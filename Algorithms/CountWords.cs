using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class CountWords
    {
        public static int CountWord(this string givenString)
        {
            string[] temp = givenString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return temp.Length;
        }
    }
}
