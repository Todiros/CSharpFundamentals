// 07. Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
class SumOf5Nums
{
    static void Main()
    {
        Console.Write("Enter a line of 5 numbers: ");
        string[] number = Console.ReadLine().Split();

        double sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            sum += double.Parse(number[i]);
        }

        Console.WriteLine("\nThe sum of the 5 numbers is: {0}\n", sum);
    }
}

