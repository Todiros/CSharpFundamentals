// 02. Write a program to sort an array of numbers and then print them back on the console. 
// The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
// Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 

// 3 44 38 5 47 15 36 26 27 2 46 4 19 50 48

using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        int[] tokens = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int currentMin = 0;
        bool isChanged = false;

        for (int exchanges = 0; exchanges < tokens.Length; exchanges++)
        {
            currentMin = exchanges;

            for (int i = exchanges; i < tokens.Length; i++)
            {
                if (tokens[currentMin] > tokens[i])
                {
                    currentMin = i;
                    isChanged = true;
                }
            }

            if (isChanged)
            {
                tokens[exchanges] ^= tokens[currentMin];
                tokens[currentMin] ^= tokens[exchanges];
                tokens[exchanges] ^= tokens[currentMin];
            }
            
            isChanged = false;
        }

        Console.WriteLine("\n{0}", string.Join(" ", tokens));
    }
}
