using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FindGCM
    {
        public static int GCM(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 )
            {
                return secondNumber;
            }

            if (secondNumber == 0)
            {
                return firstNumber;
            }

            if (firstNumber >= secondNumber)
            {
               return GCM(firstNumber % secondNumber, secondNumber);
            }
            else
            {
               return GCM(firstNumber, secondNumber % firstNumber);
            }
        }
    }
}
