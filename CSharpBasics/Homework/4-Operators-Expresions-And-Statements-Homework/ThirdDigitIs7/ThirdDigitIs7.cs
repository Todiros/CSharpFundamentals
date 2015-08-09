// 05. Write an expression that checks for given integer if its third digit from right-to-left is 7.
using System;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            int[] digits = new int[10]; 

            Console.Write("Enter integer number: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine();

            int remainder;
           
            for (int i = 0; number > 1; i++)
            {
                remainder = (int)(number % 10);
                number = number / 10;

                digits[i] = remainder;
            }

            if (digits[2] == 7)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.WriteLine();
        }
    }
}
