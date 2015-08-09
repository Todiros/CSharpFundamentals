//04. Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;

namespace RectanglePerimeterAndArea
{
    class RectanglePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter rectangle height: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = (height + width) * 2.0;
            double area = height * width;

            Console.WriteLine();

            Console.WriteLine("The perimeter of rectangle with {0} height and {1} width is: {2}", height, width, perimeter);
            Console.WriteLine("The area of rectangle with {0} height and {1} width is: {2}", height, width, area);

            Console.WriteLine();
        }
    }
}
