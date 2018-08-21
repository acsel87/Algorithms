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
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string result = "";
            string lowerCaseTemp = "";

            // Loop over each character.
            foreach (char c in givenString)
            {
                // See if character is in the table.
                if (lowerCaseTemp.IndexOf(char.ToLower(c)) == -1)
                {
                    // Append to the result.
                    result += c;
                    lowerCaseTemp += char.ToLower(c);
                }
            }
            return result;
        }
    }
}
