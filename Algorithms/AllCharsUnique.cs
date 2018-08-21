using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class AllCharsUnique
    {
        public static bool IsCharsUnique(this string givenString)
        {

            for (int i = 0; i < givenString.Length - 1; i++)
            {
                for (int j = i + 1; j < givenString.Length; j++)
                {
                    if (givenString[j] == givenString[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsCharsUniqueINDEXOF(this string givenString)
        {
            string temp = "";

            foreach (char c in givenString)
            {
                if (temp.IndexOf(c) == -1)
                {
                    temp += c;
                }

                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsCharsUniqueLINQ(this string givenString)
        {
            return givenString.Length == givenString.Distinct().Count();
        }
    }
}
