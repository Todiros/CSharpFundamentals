// 09. Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter base A: ");
        double baseA = double.Parse(Console.ReadLine());
        Console.Write("Enter base B: ");
        double baseB = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((baseA + baseB) / 2) * height;

        Console.WriteLine("\nThe area of the trapezoid with base A = {0}, base B = {1} and height = {2} is {3}!\n", baseA, baseB, height, area);
    }

}