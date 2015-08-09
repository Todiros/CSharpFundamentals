// 17. Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int gcd = 0;

        if (b > a)
        {
            b ^= a;
            a ^= b;
            b ^= a;
        }

        for (int i = 0; (a % b) != 0; i++)
        {
            gcd = a % b;
            a = b;
            b = gcd;
        }

        Console.WriteLine(gcd);

    }
}
