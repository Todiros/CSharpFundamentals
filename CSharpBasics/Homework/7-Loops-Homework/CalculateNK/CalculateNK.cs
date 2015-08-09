// 06. Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.
using System;

class CalculateNK
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        int nFact = 1;
        int kFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
            if (i <= k)
            {
                kFact = kFact * i;
            }
        }

        Console.WriteLine(nFact/kFact);
    }
}
