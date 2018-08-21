using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class AnagramString
    {
        public static bool IsAnagram (this string firstString, string secondString)
        {
            string tempString = secondString;

            if (firstString.Length == secondString.Length)
            {
                try
                {
                    foreach (char c in firstString)
                    {
                        int index = tempString.IndexOf(c);

                        if (index != -1)
                        {
                            tempString = tempString.Remove(index, 1);
                        }
                        else
                        {
                            return false;
                        }                        
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                if (tempString.Length > 0)
                {                    
                    return false;
                }

                return true;               
            }           

            return false;
        }

        public static bool IsAnagramLINQ(this string firstString, string secondString)
        {
            return string.Equals(new string(firstString.OrderBy(c => c).ToArray()), new string(secondString.OrderBy(c => c).ToArray()), StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
