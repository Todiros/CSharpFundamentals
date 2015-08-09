// 11. Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;
using System.Linq; // For the Sum() method 

class RandomizeTheNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nArr = new int[n]; // List<T> is better for larger numbers
        Random rng = new Random();

        for (int i = n; i > 0; i--)
        {
            nArr[i - 1] = i;
        }

        do 
        {
            int rndIndex = rng.Next(n);

            if (nArr[rndIndex] == 0)
            {
                continue;
            }
            else
            {
                Console.Write("{0} ", nArr[rndIndex]);
                nArr[rndIndex] = 0; // Very uneffective for larger numbers. It takes ~4 min to go through 50000 numbers. Its better using List<T>.
            }
        } while (nArr.Sum() != 0); 

        Console.WriteLine("\n");
    }
}
