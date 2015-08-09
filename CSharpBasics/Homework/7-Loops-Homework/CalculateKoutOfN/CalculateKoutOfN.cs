// 08. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
// Try to use only two loops.
using System;
using System.Numerics;

class CalculateKoutOfN
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nkFact = 1;
        BigInteger sum = 0;

        for (int y = 1; y <= n; y++)
        {
            nFact = nFact * y;

            if (y <= k)
            {
                kFact = kFact * y;
            }
        }

        for (int i = 1; i <= n - k; i++)
        {
            nkFact = nkFact * i;
        }

        sum = nFact / (kFact * nkFact);
        Console.WriteLine("{0}\n", sum);
    }
}
