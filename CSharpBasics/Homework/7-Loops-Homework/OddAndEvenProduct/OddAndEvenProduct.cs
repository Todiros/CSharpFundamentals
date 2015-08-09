// 10. You are given n integers (given in a single line, separated by a space). 
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split();
        int n = line.Length;
        int[] numbers = new int[n];
        int evenProduct = 1;
        int oddProduct = 1;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(line[i]);
            int digit = numbers[i];

            if ((i + 1) % 2 == 0)
            {
                evenProduct *= digit;
            }
            else
            {
                oddProduct *= digit;
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("\nYes \nProduct: {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("\nNo \nEvenProduct: {0} \nOddProduct: {1}", evenProduct, oddProduct);
        }

        Console.WriteLine();
    }
}
