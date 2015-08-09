// 10. Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;

class PointInCircleAndRectangle
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());

        double centerX = 1;
        double centerY = centerX;
        double radius = 1.5;

        bool isInsideCircle = Math.Sqrt((x-centerX) * (x-centerX) + (y-centerY) * (y-centerY)) <= radius; 
        bool isNotInsideRect = y > 1;

        if (isInsideCircle && isNotInsideRect)
        {
            Console.WriteLine("YES! It is inside the Circle and outside the Rectangle!");
        }
        else
        {
            Console.WriteLine("NO! It is not inside the Cirlce and outside the Rectangle!");
        }
    }
}

