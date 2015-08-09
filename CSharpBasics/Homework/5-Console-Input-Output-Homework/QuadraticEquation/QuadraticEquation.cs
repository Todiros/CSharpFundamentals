// 06. Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - 4 * a * c; 
        double x1 = 0;
        double x2 = 0;

        if (d > 0)
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a); 
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("\nX1 = {0}\nX2 = {1}\n", x1, x2);
        }
        else if (d == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("\nX1,X2 = {0}\n", x1);
        }
        else
        {
            Console.WriteLine("\nNo Real Roots\n");
        }
    }
}

