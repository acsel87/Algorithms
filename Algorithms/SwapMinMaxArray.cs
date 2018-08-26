using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SwapMinMaxArray
    {
        public static int[] SwapMinMax(this int[] givenArray)
        {
           
            int minIndex = 0;            
            int maxIndex = 0;
            int maxTemp = 0;

            for (int i = 0; i < givenArray.Length; i++)
            {
                if (givenArray[i] < givenArray[minIndex])
                {                    
                    minIndex = i;
                }

                else if (givenArray[i] > givenArray[maxIndex])
                {
                    maxIndex = i;
                }
            }
            maxTemp = givenArray[minIndex];
            givenArray[minIndex] = givenArray[maxIndex];
            givenArray[maxIndex] = maxTemp;

            return givenArray;
        }
    }
}
