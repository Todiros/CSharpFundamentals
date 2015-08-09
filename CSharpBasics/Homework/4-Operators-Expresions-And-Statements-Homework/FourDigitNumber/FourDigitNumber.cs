//06. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// - Prints on the console the number in reversed order: dcba (in our example 1102).
// - Puts the last digit in the first position: dabc (in our example 1201).
// - Exchanges the second and the third digits: acbd (in our example 2101).
using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int[] digits = new int[4];

            Console.Write("Enter four-digit integer number: ");
            int number = int.Parse(Console.ReadLine());
            int reserveNumber = number;

            int remainder;
            int sumOfDigits = 0;
            int reversedOrder = 0;

            // fill the array with digits

            for (int i = 0; i < digits.Length; i++)
            {
                remainder = number % 10;
                number = number / 10;

                digits[i] = remainder;
            }

            // in reversed order

            for (int i = 0; i < digits.Length; i++)
            {
                reversedOrder = reversedOrder + digits[i];
                reversedOrder = reversedOrder * 10;
            }

            reversedOrder = reversedOrder / 10; // removing the extra 0 from the number

            // the sum of digits

            for (int i = 0; i < digits.Length; i++)
			{
                sumOfDigits = sumOfDigits + digits[i];   
			}

            Array.Reverse(digits); // Reverses the digits in the correct order 

            // Last digit to first

            int lastToFirst = int.Parse("" + digits[3] + digits[0] + digits[1] + digits[2]);

            // Exchange second with the third digit

            int secondToThird = int.Parse("" + digits[0] + digits[2] + digits[1] + digits[3]); 

            // print

            Console.WriteLine();
            Console.WriteLine("The sum from the digits in {0} is {1}!", reserveNumber, sumOfDigits);
            Console.WriteLine("The digits in number {0} in reverse order are {1}!", reserveNumber, reversedOrder);
            Console.WriteLine("The number {0} with last digit moved to the first place is {1}!", reserveNumber, lastToFirst);
            Console.WriteLine("The number {0} with the second digit exchanged with the third is {1}!\n", reserveNumber, secondToThird);
        }
    }
}
