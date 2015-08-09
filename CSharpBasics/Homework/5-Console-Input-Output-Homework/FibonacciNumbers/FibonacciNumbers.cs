// 10. Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces): 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int next = 1;
        int previous = 0;
        int current = 0;

        Console.Write(current);

        DateTime startTime = DateTime.Now;

        for (int i = 1; i < n; i++)
        {
            current = next;
            next = current + previous;
            previous = current;
            Console.Write(", {0}", current);
        }

        DateTime endTime = DateTime.Now;

        Console.WriteLine("\n\nIt took {0} to finish!\n", endTime - startTime);
    }
}

