// 09.Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.
// n = 3
// 1 2 3
// 2 3 4 
// 3 4 5 
using System;

class MatrixOfNumbers
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int y = 1; y <= n; y++)
            {
                Console.Write("{0} ", y + i);
            }
            Console.WriteLine();
        }
    }
}
