using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class MostUsedChar
    {
        public static char CharMostUsed(this string givenString)
        {
            char bestChar = ' ';

            Dictionary<char, int> chars = new Dictionary<char, int>();

            int temp;

            foreach (char c in givenString)
            {
                if (chars.ContainsKey(c))
                {
                    chars.TryGetValue(c, out temp);
                    chars[c] = temp + 1;                    
                }
                else
                {
                    chars.Add(c, 1);
                }
            }

            int maxValue = chars.Select(x => x.Value).Max();

            foreach (KeyValuePair<char, int> pair in chars)
            {
                if (pair.Value == maxValue)
                {
                    bestChar = pair.Key;
                    break;
                }
            }

            return bestChar;
        }

        public static char CharMostUsedLINQ(this string givenString)
        {            
            return givenString.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }
    }
}
