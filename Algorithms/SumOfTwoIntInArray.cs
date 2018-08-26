using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SumOfTwoIntInArray
    {
        public static bool IsSumOfTwoInt(this int[] givenArray, int givenValue)
        {
            for (int i = 0; i < givenArray.Length - 1; i++)
            {
                for (int j = i+1; j < givenArray.Length; j++)
                {
                    if (givenArray[i] + givenArray[j] == givenValue)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
