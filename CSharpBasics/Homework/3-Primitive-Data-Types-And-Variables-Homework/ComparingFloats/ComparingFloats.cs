//13. Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            //double da = -0.0000007; // true
            //double db = 0.00000007;
            //double na = -4.999999; // false
            //double nb = -4.999998;
            //double pa = 5.3; // false
            //double pb = 6.01;
            //double pla = 5.00000005; // true
            //double plb = 5.00000001;

            double firstFloatNum = 0;
            double secondFloatNum = 0;
            double eps = 0.000001;
            double sum = 0;

            try
            {
                Console.Write("A: ");
                firstFloatNum = double.Parse(Console.ReadLine());
                Console.Write("B: ");
                secondFloatNum = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Try again! ;)");
                Environment.Exit(1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Try again! ;)");
                Environment.Exit(1);
            }

            Console.WriteLine();

            if (firstFloatNum < 0 && secondFloatNum > 0 || firstFloatNum < 0 && secondFloatNum < 0)           
            {
                sum = (-1 * firstFloatNum) + secondFloatNum;
            }
            else if (firstFloatNum > 0 && secondFloatNum < 0)
            {
                sum = (-1 * secondFloatNum) + firstFloatNum;
            }
            else
            {
                sum = firstFloatNum - secondFloatNum;
            }
           
            if (sum < 0)
            {
                sum = sum * (-1);
            }

            if (sum < eps)
            {
                Console.WriteLine("The numbers are equal!");
                Console.WriteLine("Difference: {0}", sum);       
            }
            else
            {
                Console.WriteLine("The numbers are different!");
                Console.WriteLine("Difference: {0}", sum);
            }
        }
    }
}
