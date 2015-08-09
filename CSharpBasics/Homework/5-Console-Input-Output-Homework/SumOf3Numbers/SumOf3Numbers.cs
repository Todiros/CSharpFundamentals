// 01. Write a program that reads 3 real numbers from the console and prints their sum.
using System;
class SumOf3Numbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        decimal sum = a + b + c;

        Console.WriteLine("The sum of a = {0}, b = {1} and c = {2} is {3}!\n", a, b, c, sum);
    }
}
