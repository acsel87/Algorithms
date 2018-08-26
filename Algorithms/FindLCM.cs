using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FindLCM
    {
        public static int LCM(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                return 0;
            }

            if (firstNumber > secondNumber)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
            }

            for (int i = 1; i < secondNumber - 1; i++)
            {
                if ((firstNumber * i) % secondNumber == 0)
                {
                    return firstNumber * i;
                }
            }
            return firstNumber * secondNumber;

        }
    }   
}
