// 08. Write an expression that checks if given positive integer number n (n ≤ 100) is prime
using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        short number = short.Parse(Console.ReadLine());

        if (((number % 2 > 0) && (number % 3 > 0) || (number == 2) || (number == 3)) && (number != 1))    
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");
        }
    }
}

