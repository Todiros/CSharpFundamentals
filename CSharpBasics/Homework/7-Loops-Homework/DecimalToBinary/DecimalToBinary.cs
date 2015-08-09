// 14. Using loops write a program that converts an integer number to its binary representation. 
// The input is entered as long. 
// The output should be a variable of type string. Do not use the built-in .NET functionality. 
using System;

class DecimalToBinary
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        bool flag = true;
        string binaryN = "";

        if (n == 0)
        {
            Console.WriteLine(0);
            Environment.Exit(0);
        }

        for (int i = 0; flag; i++)
        {
            //byte bit = (byte)(n % 2);

            if (n == 1)
            {
                binaryN = "1" + binaryN;
                flag = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    binaryN = "0" + binaryN;
                }
                else
                {
                    binaryN = "1" + binaryN;
                }
            }

            n = n / 2;
        }

        Console.WriteLine(binaryN);
    }
}
