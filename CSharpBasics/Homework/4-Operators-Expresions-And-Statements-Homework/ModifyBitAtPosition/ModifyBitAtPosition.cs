// 14. We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p... 
// ...from the binary representation of n while preserving all other bits in n.
using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter N ({0} - {1}): ", ushort.MinValue, ushort.MaxValue);
        ushort n = ushort.Parse(Console.ReadLine());

        Console.Write("Enter position (0 - 15): ");
        ushort p = ushort.Parse(Console.ReadLine());

        Console.Write("Enter bit value (0 - 1): ");
        byte v = byte.Parse(Console.ReadLine());

        ushort mask = (ushort)(1 << p);

        if (v == 1)
        {
            Console.WriteLine(n | mask);
        }
        else
        {
            Console.WriteLine(n & ~mask);
        }
    }
}
