// 08. Create a console application that calculates and prints the square root of the number 12345.
using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            int number = 12345;
            double squareRoot;

            squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}!", number, squareRoot);
        }
    }
}
