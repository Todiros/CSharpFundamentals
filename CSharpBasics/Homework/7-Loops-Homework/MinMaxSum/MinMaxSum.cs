// 03. Write a program that reads from the console a sequence of n integer numbers and returns...
// ...the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
using System;

class MinMaxSum
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        int sum = 0;
        double avg = 0;


        for (int i = 0; i < n; i++)
        {
            int num = Int32.Parse(Console.ReadLine());
            sum = sum + num;

            if (num >= max)
            {
                max = num;
            }

            if (i < 1)
            {
                min = num;
            }
            else if (num <= min)
            {
                min = num;
            }
        }

        avg = (double)sum / n;

        Console.WriteLine("\nMin: {0} \nMax: {1} \nSum: {2} \nAvg: {3:#.##}\n", min, max, sum, avg);
    }
}
