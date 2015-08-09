// 07. Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInside = ((x * x) + (y * y)) <= (2 * 2);

        if (isInside)
        {
            Console.WriteLine("It is inside!");
        }
        else
        {
            Console.WriteLine("It is outside!");
        }
    }
}

