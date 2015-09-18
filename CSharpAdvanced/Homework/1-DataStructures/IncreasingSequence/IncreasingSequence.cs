// Write a program to find all increasing sequences inside an array of integers. 
// The integers are given on a single line, separated by a space. 
// Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. 
// Find also the longest increasing sequence and print it at the last line. 
// If several sequences have the same longest length, print the left-most of them. 

//2 3 4 1 50 2 3 4 5
//1 7 4 3 6 9 

using System;
using System.Linq;

class IncreasingSequence
{
    static void Main()
    {
        int[] numbers =
            Console.ReadLine().Split((char[]) null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int sequenceCount = 1;
        int longestSeq = 0;
        int sequenceEnd = 0;

        Console.Write("\n{0} ", numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] < numbers[i])
            {
                Console.Write("{0} ", numbers[i]);
                sequenceCount++;
            }
            else
            {
                Console.Write("\n{0} ", numbers[i]);

                if (longestSeq < sequenceCount)
                {
                    longestSeq = sequenceCount;
                    sequenceEnd = i - 1;
                }
                sequenceCount = 1;
            }
        }

        if (sequenceCount > longestSeq || longestSeq == 0)
        {
            longestSeq = sequenceCount;
            
            sequenceEnd = numbers.Length - 1;
        }

        Console.Write("\nLongest Sequence: ");

        for (int i = sequenceEnd - longestSeq + 1; i <= sequenceEnd; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine("\n");
    }
}

