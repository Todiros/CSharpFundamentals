// 04. Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). 
// The input strings are given as a single line, separated by a space.

using System;

class EqualString
{
    static void Main()
    {
        string[] tokens = Console.ReadLine().Split((char[]) null, StringSplitOptions.None);

        int elementsInSeq = 0;
        int longestSeq = 0;
        
        for (int i = 0; i < tokens.Length - 1; i++)
        {
            if (tokens[i] == tokens[i + 1])
            {
                Console.Write("{0} ", tokens[i]);

                if (i == tokens.Length - 2)
                {
                    Console.Write("{0} ", tokens[i + 1]);
                }
            }
            else
            {
                Console.WriteLine(tokens[i]);

                if (i == tokens.Length - 2)
                {
                    Console.WriteLine("{0} ", tokens[i + 1]);
                }
            }
        }

        Console.WriteLine();
    }
}
