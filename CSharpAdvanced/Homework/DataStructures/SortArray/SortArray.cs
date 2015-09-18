// 01. Write a program to read an array of numbers from the console, sort them and print them back on the console. 
// The numbers should be entered from the console on a single line, separated by a space.
using System;
using System.Linq;
using System.Diagnostics;

// 5 7 21 22 4 18 1 4
// 5 1 7 14 3

class SortArray
{
    static void Main()
    {
        Stopwatch executingTime = new Stopwatch();
        executingTime.Start();

        int[] tokens = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int initialPasses = tokens.Length; // (int)Math.Pow(tokens.Length, 2) - not necessary;
        int passesNeeded = 1;
        bool isChanged = false;

        for (int j = 0; j < initialPasses; j++)
        {
            for (int i = 0; i < tokens.Length - 1; i++)
            {
                if (tokens[i] > tokens[i + 1])
                {
                    tokens[i] ^= tokens[i + 1];
                    tokens[i + 1] ^= tokens[i];
                    tokens[i] ^= tokens[i + 1];

                    isChanged = true;
                }
            }

            if (isChanged)
            {
                passesNeeded++;
            }
            isChanged = false;
        }

        executingTime.Stop();

        Console.WriteLine("\nsorted: {0}", string.Join(" ", tokens));
        Console.WriteLine("\ninitial passes: {0}\npasses needed: {1}", initialPasses, passesNeeded);
        Console.WriteLine("executing time: {0:F3} milliseconds.\n", executingTime.Elapsed.TotalSeconds);
    }
}
