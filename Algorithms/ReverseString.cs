using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ReverseString
    {
        public static string ReverseStr(this string givenString)
        {
            string temp = givenString;

            string result = "";

            if (temp.Length == 1)
            {
                return temp;
            }

            result = temp.Last() + temp.Substring(0, temp.Length - 1).ReverseStr();

            return result;
        }
    }
}
