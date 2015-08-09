// 03. Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double pi = 3.14;

        double perimeter = 2 * pi * r;
        double area = pi * Math.Pow(r, 2); // pi * r * r 

        Console.WriteLine("perimeter = {0:F2}\narea = {1:F2}\n", perimeter, area);
    }
}

