// 03. Write a program that reads N floating-point numbers from the console. 
// Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. 
// Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).

//1.2 -4 5.00 12211 93.003 4 2.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class CategorizeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] tokens = Console.ReadLine().Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        //string[] line = Console.ReadLine().Split();
        //double[] tokens = line.Select(double.Parse).ToArray();

        List<double> doubleNumbers = new List<double>();
        List<int> intNumbers = new List<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] % 1 == 0)
            {
                intNumbers.Add((int)tokens[i]);
            }
            else
            {
                doubleNumbers.Add(tokens[i]);
            }
        }

        intNumbers.Sort();
        doubleNumbers.Sort();

        Console.WriteLine("[{0}]", string.Join(", ", doubleNumbers));
        Console.WriteLine("min: {0:F2}, max: {1:F2}, sum: {2:F2}, avg: {3:F2}", 
            doubleNumbers[0], 
            doubleNumbers[doubleNumbers.Count - 1], 
            doubleNumbers.Sum(), 
            doubleNumbers.Average()
            );

        Console.WriteLine();

        Console.WriteLine("[{0}]", string.Join(", ", intNumbers));
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3}", 
            intNumbers[0], 
            intNumbers[intNumbers.Count - 1], 
            intNumbers.Sum(), 
            intNumbers.Average()
            );
    }
}
