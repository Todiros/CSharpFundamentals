// 09. Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
using System;
    class SumOfNNums
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n{0}", sum);
        }
    }

