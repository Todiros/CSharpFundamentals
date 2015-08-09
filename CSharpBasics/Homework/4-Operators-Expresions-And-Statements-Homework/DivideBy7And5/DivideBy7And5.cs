// 03. Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isDivided = (number % 5 == 0) && (number % 7 == 0);
            
            Console.WriteLine();

            Console.WriteLine(isDivided);

            Console.WriteLine();
        }
    }
}
