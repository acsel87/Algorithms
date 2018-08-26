using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class MoveZerosToEnd
    {
        public static int[] MoveZeroesEnd(this int[] givenArray)
        {
            int curIndex = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] != 0)
                {
                    givenArray[curIndex] = givenArray[i];
                    curIndex++;
                }
            }

            for (int i = curIndex; i < givenArray.Length; i++)
            {
                givenArray[i] = 0;
            }

            return givenArray;
        }
    }
}
