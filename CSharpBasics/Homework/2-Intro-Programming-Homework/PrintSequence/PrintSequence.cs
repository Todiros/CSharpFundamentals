// 09. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            for (double i = 2; i < 12; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i); 
                }
                else
                {
                    Console.WriteLine("-{0}", i);
                }
            }
        }
    }
}
