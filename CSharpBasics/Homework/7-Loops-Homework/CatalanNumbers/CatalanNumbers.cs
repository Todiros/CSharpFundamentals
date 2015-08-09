// 08. Write a program to calculate the nth Catalan number by given n (1 < n < 100).
using System;
using System.Numerics;

class CatalanNumbers
{
    static BigInteger Factorial(int n)
    {
        BigInteger factSum = 1;
        for (int i = n; i > 0; i--)
        {
            factSum = factSum * i;
        }
        return factSum;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger catalanNum = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));

        Console.WriteLine(catalanNum);
    }
}
