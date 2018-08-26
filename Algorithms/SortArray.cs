using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SortArray
    {
        public static int[] SortIntArrayAsc(this int[] givenArray, bool sortAsc = true)
        {
            int[] tempArray = new int[givenArray.Length];

            for (int i = 1; i < givenArray.Length; i++)
            {
                for (int j = i; j > 0 && (sortAsc ? givenArray[j - 1] > givenArray[j] : givenArray[j - 1] < givenArray[j]); j--)                
                {                    
                    SwapIndexInArray(givenArray, j - 1, j);                    
                }
            }

            return givenArray;
        }

        private static void SwapIndexInArray(int[] givenArray, int i, int j)
        {
            int temp = givenArray[i];
            givenArray[i] = givenArray[j];
            givenArray[j] = temp;
        }
    }
}
