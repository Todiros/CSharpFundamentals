//08. Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©

using System;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char copyrightSymbol = '\u00A9';
            int row = 4;
            double col = 2 * row - 1;
            double counter = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j < (col / 2 - counter / 2) || j > (col / 2 + counter / 2 - 1))
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write(copyrightSymbol);
                }
                counter = counter + 2;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
