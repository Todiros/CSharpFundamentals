// 11. Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
// The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter N({0}-{1}): ", ushort.MinValue, ushort.MaxValue);
        ushort n = ushort.Parse(Console.ReadLine());
        ushort p = 3;

        ushort nRightP = (ushort)(n >> p);
        ushort bit = (ushort)(nRightP & 1);

        Console.WriteLine(bit);
    }
}
