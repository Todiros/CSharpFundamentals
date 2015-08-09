// Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
// Your program should work well for very big numbers, e.g. n=100000. 
using System;

class TrailingZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int trailingZeros = 0;

        for (int i = 1; Math.Pow(5,i) <= n; i++)
        {
            int factor = (int)Math.Pow(5, i);
            trailingZeros += n / factor;
        }

        Console.WriteLine("{0}! has {1} trailing zeros!", n, trailingZeros);          
    }
}
