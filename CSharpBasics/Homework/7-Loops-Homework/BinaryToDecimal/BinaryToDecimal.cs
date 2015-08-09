// 13. Using loops write a program that converts a binary integer number to its decimal form. 
// The input is entered as string. The output should be a variable of type long. 
// Do not use the built-in .NET functionality.
using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main()
    {
        BigInteger line = BigInteger.Parse(Console.ReadLine());
        long numInDec = 0; // If you change the type to BigInteger it will work with even larger numbers!
        bool flag = true;

        if (line == 0)
        {
            Console.WriteLine(0);
            Environment.Exit(0);
        }

        for (int i = 0; flag; i++)
        {
            byte bit = (byte)(line % 10);

            if (bit == 0)
            {
                line = line / 10;
                continue;
            }
            else
            {
                numInDec = numInDec + (long)Math.Pow(2, i);

                if (line <= 1)
                {
                    flag = false;
                }

                line = line / 10;
            }
        }

        Console.WriteLine(numInDec);
    }
}
