using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class PadArray
    {
        public static T[] PadAnyArray<T>(this T[] givenArray, int index)
        {
            T[] newArray = new T[givenArray.Length];

            for (int i = 0; i < givenArray.Length; i++)
            {
                newArray[Math.Abs(givenArray.Length - i + index) % givenArray.Length] = givenArray[i];
            }

            return newArray;
        }

        /// <summary>
        /// WIP
        /// - put an array value in an auxiliar variable.
        /// - find the new value padded to the index of the value in aux
        /// - find the new value padded to the index of the previous padded value
        /// - etc
        /// - put aux value in the remaining index
        /// </summary>        
        public static T[] PadAnyArrayAux<T>(this T[] givenArray, int index)
        {
            T aux = givenArray[0];

            for (int i = 0; i < givenArray.Length; i++)
            {
                givenArray[0] = givenArray[Math.Abs(4 - 1 + -1*-1) % 3];
            }

            return givenArray;
        }
    }
}

//              1           123
//              123     1    23
//              231     |   2 3
//                      |   23 
//                      |    231
//                      |      ^
//                      |______|