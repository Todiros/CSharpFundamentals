// 01.Write an expression that checks if given integer is odd or even.
using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int[] intArr = {2, 3, -1, 5, 4, -2, 1, 0, 7, 6};

            for (int i = 0; i < intArr.Length; i++)
            {
                if ((intArr[i] % 2) == 0)
                {
                    Console.WriteLine("The integer {0} is EVEN!", intArr[i]);
                }
                else
                {
                    Console.WriteLine("The integer {0} is ODD!", intArr[i]);
                }
            }
        }
    }
}
