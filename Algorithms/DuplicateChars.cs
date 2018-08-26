using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class DuplicateChars
    {       
        public static string RemoveDuplicateChars(this string givenString)
        {           
            string result = "";
            string lowerCaseTemp = "";
                        
            foreach (char c in givenString)
            {                
                if (lowerCaseTemp.IndexOf(char.ToLower(c)) == -1)
                {                   
                    result += c;
                    lowerCaseTemp += char.ToLower(c);
                }
            }
            return result;
        }
    }
}
