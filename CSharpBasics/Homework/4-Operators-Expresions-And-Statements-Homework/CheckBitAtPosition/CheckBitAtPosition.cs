// 13. Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 
using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter N ({0} - {1}): ", ushort.MinValue, ushort.MaxValue);
        ushort n = ushort.Parse(Console.ReadLine());

        Console.Write("Enter position (0 - 15): ");
        ushort p = ushort.Parse(Console.ReadLine());

        ushort nRightP = (ushort)(n >> p);
        //ushort bit = (ushort)(nRightP & 1);

        bool isBitOne = (nRightP & 1) == 1;

        Console.WriteLine(isBitOne);
    }
}
