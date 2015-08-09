// 12. Write an expression that extracts from given integer n the value of given bit at index p. 
using System;

class ExtractBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter N ({0} - {1}): ", ushort.MinValue, ushort.MaxValue);
        ushort n = ushort.Parse(Console.ReadLine());

        Console.Write("Enter position (0 - 15): ");
        ushort p = ushort.Parse(Console.ReadLine());

        ushort nRightP = (ushort)(n >> p);
        ushort bit = (ushort)(nRightP & 1);

        Console.WriteLine("The {0} bit is {1}!", p, bit);
    }
}
